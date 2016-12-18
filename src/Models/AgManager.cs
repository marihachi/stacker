using Stacker.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Stacker.Models
{
	public class AgManager : IDisposable
	{
		public AgManager()
		{
			AgProgram lastCheckProgram = null;
			AgReservation lastCheckReservation = null;
			SecTimer = new Timer { Interval = 1000, Enabled = true };
			SecTimer.Tick += (s, ev) =>
			{
				if (lastCheckProgram != NowProgram)
				{
					lastCheckProgram = NowProgram;

					OnProgramTransitioned();
				}
				
				var nowReservation = ReservationList.Find(i => i.IsInRange);

				if (lastCheckReservation == null && nowReservation != null)
				{
					Debug.WriteLine("開始");
					OnReservationTransitioned(ReservationTransitionEventArgs.ReservationTransitionType.Begin, nowReservation);
					lastCheckReservation = nowReservation;
				}

				if (lastCheckReservation != null && (nowReservation == null || !lastCheckReservation.IsInRange))
				{
					Debug.WriteLine("終了");
					OnReservationTransitioned(ReservationTransitionEventArgs.ReservationTransitionType.End, lastCheckReservation);
					lastCheckReservation = null;
				}
			};

			ProgramList = new ValidateableList<AgProgram>(i => i != null);
			ReservationList = new ValidateableList<AgReservation>(i =>
			{
				if (i == null)
					return false;

				// 予約時間の重複がないかどうか
				foreach(var reservation in ReservationList)
				{
					if (i.StartTime >= reservation.StartTime && i.StartTime < reservation.EndTime || i.EndTime > reservation.StartTime && i.EndTime <= reservation.EndTime)
						return false;
				}

				return true;
			});
		}

		public Uri ProgramListUrl { get; set; } = new Uri("http://www.agqr.jp/timetable/streaming.html");

		public ValidateableList<AgProgram> ProgramList { get; private set; }

		public ValidateableList<AgReservation> ReservationList { get; private set; }

		private Timer SecTimer { get; set; }
		private Process ReservationConsoleProcess { get; set; }
		private Process RealtimeConsoleProcess { get; set; }
		private string RealtimeFilename { get; set; }
		private string ReservationFilename { get; set; }

		public bool IsRealtimeRecording => RealtimeConsoleProcess != null;

		public bool IsReservationRecording => ReservationConsoleProcess != null;

		public AgProgram NowProgram => ProgramList.Find(p => p.IsOnAir);

		private void CreateOutputDirectory()
		{
			var dir = $"./library/ag/";
			if (!Directory.Exists(dir))
				Directory.CreateDirectory(dir);
		}

		public void RecordSpecifiedTime(int specifiedTimeSec, string filename, bool isRealtimeRecord)
		{
			StartRecord(filename, isRealtimeRecord);
			Task.Delay(TimeSpan.FromSeconds(specifiedTimeSec)).Wait();
			StopRecord(isRealtimeRecord);
		}

		public void StartRecord(string filename, bool isRealtimeRecord)
		{
			CreateOutputDirectory();
			var process = ConsoleExecuter.StartOnConsole(
				$"rtmpdump -v -r \"rtmpe://fms1.uniqueradio.jp/\" -a ?rtmp://fms-base2.mitene.ad.jp/agqr/ -y aandg22 | ffmpeg -y -i pipe:0 ./library/ag/{(isRealtimeRecord ? "temp_realtime" : "temp_reservation")}.mp3");

			if (isRealtimeRecord)
			{
				RealtimeFilename = filename;
				RealtimeConsoleProcess = process;
			}
			else
			{
				ReservationFilename = filename;
				ReservationConsoleProcess = process;
			}

			OnRecordStarted(isRealtimeRecord);
		}

		public void StopRecord(bool isRealtimeRecord)
		{
			if (isRealtimeRecord && RealtimeConsoleProcess != null)
			{
				ConsoleExecuter.StopConsole(RealtimeConsoleProcess);
				File.Move("./library/ag/temp_realtime.mp3", $"./library/ag/{Regex.Replace(RealtimeFilename, @"[\/:*?""<>|]+", i => " ")}.mp3");
				OnRecordStopped(true);
				RealtimeConsoleProcess = null;
			}

			if (!isRealtimeRecord && ReservationConsoleProcess != null)
			{
				ConsoleExecuter.StopConsole(ReservationConsoleProcess);
				File.Move("./library/ag/temp_reservation.mp3", $"./library/ag/{Regex.Replace(ReservationFilename, @"[\/:*?""<>|]+", i => " ")}.mp3");
				OnRecordStopped(false);
				ReservationConsoleProcess = null;
			}
		}

		public class RecordEventArgs : EventArgs
		{
			public RecordEventArgs(bool isRealtimeRecord, string filename)
			{
				IsRealtimeRecord = IsRealtimeRecord;
				Filename = filename;
			}

			public bool IsRealtimeRecord { get; set; }

			public string Filename { get; set; }
		}

		public class ReservationTransitionEventArgs : EventArgs
		{
			public ReservationTransitionEventArgs(ReservationTransitionType type, AgReservation reservation)
			{
				Type = type;
				Reservation = reservation;
			}

			public ReservationTransitionType Type { get; set; }

			public AgReservation Reservation { get; set; }

			public enum ReservationTransitionType
			{
				Begin,
				End
			}
		}

		public event EventHandler<RecordEventArgs> RecordStarted;
		public void OnRecordStarted(bool isRealtimeRecord)
		{
			RecordStarted?.Invoke(this, new RecordEventArgs(isRealtimeRecord, isRealtimeRecord ? RealtimeFilename : ReservationFilename));
		}

		public event EventHandler<RecordEventArgs> RecordStopped;
		public void OnRecordStopped(bool isRealtimeRecord)
		{
			RecordStopped?.Invoke(this, new RecordEventArgs(isRealtimeRecord, isRealtimeRecord ? RealtimeFilename : ReservationFilename));
		}

		public event EventHandler ProgramTransitioned;
		public void OnProgramTransitioned()
		{
			ProgramTransitioned?.Invoke(this, new EventArgs());
		}

		public event EventHandler<ReservationTransitionEventArgs> ReservationTransitioned;
		public void OnReservationTransitioned(ReservationTransitionEventArgs.ReservationTransitionType type, AgReservation reservation)
		{
			ReservationTransitioned?.Invoke(this, new ReservationTransitionEventArgs(type, reservation));
		}

		private IList<AgProgram> AnalyzeProgramList()
		{
			var weekTimeSum = new List<TimeSpan>(Enumerable.Repeat(TimeSpan.FromHours(6), 7));

			var programListHtmlStream = new HttpClient().GetAsync(ProgramListUrl).Result.Content.ReadAsStreamAsync().Result;
			var programListXhtml = HtmlUtility.Parse(new StreamReader(programListHtmlStream));
			var trs = programListXhtml.Descendants("tbody").First().Elements("tr");

			// 曜日毎の番組リスト
			var programsWeek = new List<List<AgProgram>>();
			foreach (var i in Enumerable.Range(0, 7))
				programsWeek.Add(new List<AgProgram>());

			foreach (var tr in (from tr in trs where tr.HasElements select tr))
			{
				var time = TimeSpan.FromHours(6).Add(TimeSpan.FromMinutes(trs.ToList().IndexOf(tr)));
				foreach (var td in tr.Elements("td"))
				{
					var weekIndex = weekTimeSum.FindIndex(i => time.TotalMinutes >= i.TotalMinutes); // 曜日を算出(今の時間が、その曜日の時間の合計より大きいか同じなら)
					var lengthMin = TimeSpan.FromMinutes(int.Parse(td.Attribute("rowspan").Value));
					weekTimeSum[weekIndex] = time + lengthMin;

					var classes = td.Elements("div").Attributes("class");

					var title = (from cls in classes where cls.Value == "title-p" select cls.Parent.Value).First();
					var personality = (from cls in classes where cls.Value == "rp" select cls.Parent.Value).First();
					var hasVideo = (from cls in classes where cls.Value == "time" select cls.Parent).First()
						.Element("span")?.Elements("img")?.Attributes("src").ToList().Exists(att => att.Value == "http://cdn-agqr.joqr.jp/schedule/img/icon_m.gif") ?? false;

					programsWeek[weekIndex].Add(new AgProgram(Regex.Match(title, "([^\n]*)$").Groups[1].Value, time, lengthMin, personality, hasVideo));
				}
			}

			// 曜日毎の番組リストを日数に換算して統合
			var res = new List<AgProgram>();
			foreach(var programs in programsWeek)
			{
				var weekDayIndex = programsWeek.IndexOf(programs);

				foreach (var program in programs)
				{
					// -- 日曜日から始まるようにする --

					// 曜日番号をそれぞれ +1 する
					program.Time = program.Time.Add(TimeSpan.FromDays(weekDayIndex + 1));

					// 曜日番号が7以上なら7日分減らす
					if (program.Time.Days >= 7)
						program.Time = program.Time.Subtract(TimeSpan.FromDays(7)); 

					res.Add(program);
				}
			}

			// 時間順でソート
			res.Sort((x, y) => (int)(x.Time.TotalMinutes - y.Time.TotalMinutes));

			return res;
		}

		/// <summary>
		/// 番組表情報を再取得します
		/// </summary>
		public void UpdateProgramList()
		{
			ProgramList.Clear();
			ProgramList.AddRange(AnalyzeProgramList());
		}

		public void Dispose()
		{
			if (ReservationConsoleProcess != null)
				StopRecord(false);

			if (RealtimeConsoleProcess != null)
				StopRecord(true);
		}
	}
}
