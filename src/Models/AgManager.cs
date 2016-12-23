using Stacker.Models.Enums;
using Stacker.Models.EventArgses;
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
			AgTimeReservation targetTimeReservation = null;
			AgProgram targetProgramKeywordReservation = null;

			SecTimer = new Timer { Interval = 1000, Enabled = true };
			SecTimer.Tick += (s, ev) =>
			{
				if (lastCheckProgram != NowProgram)
				{
					lastCheckProgram = NowProgram;
					OnProgramTransitioned();
				}

				var needRecordingTimeReservation = TimeReservationList.Find(i => i.NeedRecording);

				// 時間予約されている and 時間予約を完了する必要がある
				if (targetTimeReservation != null && !targetTimeReservation.NeedRecording)
				{
					// 時間予約終了
					StopRecord(false);
					OnTimeReservationStoped(targetTimeReservation);
					targetTimeReservation = null;
					Debug.WriteLine("AgManager: 時間予約を終了しました");
				}

				// キーワード予約されている and (キーワード予約を完了する必要がある or 番組が遷移されている or (時間予約を開始する必要がある and 時間予約されてない))
				if (targetProgramKeywordReservation != null && (!NeedKeywordRecording || targetProgramKeywordReservation != NowProgram) || (needRecordingTimeReservation != null && targetTimeReservation == null))
				{
					// キーワード予約終了
					StopRecord(false);
					OnKeywordReservationStoped(targetProgramKeywordReservation);
					targetProgramKeywordReservation = null;
					Debug.WriteLine("AgManager: キーワード予約を終了しました");
				}

				// 時間予約されてない
				if (targetTimeReservation == null)
				{
					// 時間予約を開始する必要がある
					if (needRecordingTimeReservation != null)
					{
						// 時間予約開始
						StartRecord($"{DateTime.Now.Year:0000}{DateTime.Now.Month:00}{DateTime.Now.Day:00}_{needRecordingTimeReservation.Name}", needRecordingTimeReservation.IsRecordVideo, false);
						OnTimeReservationStarted(needRecordingTimeReservation);
						targetTimeReservation = needRecordingTimeReservation;
						Debug.WriteLine("AgManager: 時間予約を開始しました");
					}

					// キーワード予約を開始する必要がある and キーワード予約されてない
					if (NeedKeywordRecording && targetProgramKeywordReservation == null)
					{
						// キーワード予約開始
						StartRecord($"{DateTime.Now.Year:0000}{DateTime.Now.Month:00}{DateTime.Now.Day:00}_{NowProgram.Title}", NowProgram.HasVideo, false);
						OnKeywordReservationStarted(targetProgramKeywordReservation);
						targetProgramKeywordReservation = NowProgram;
						Debug.WriteLine("AgManager: キーワード予約を開始しました");
					}
				}
			};

			ProgramList = new ValidateableList<AgProgram>(i => i != null);
			TimeReservationList = new ValidateableList<AgTimeReservation>(i =>
			{
				if (i == null)
					return false;

				return !IsDuplicateReservation(i.Name, i.StartTime, i.EndTime, i);
			});
			KeywordReservationList = new ValidateableList<AgKeywordReservation>(i =>
			{
				if (i == null || i.Keyword == "")
					return false;

				return true;
			});
		}

		public Uri ProgramListUrl { get; set; } = new Uri("http://www.agqr.jp/timetable/streaming.html");

		public ValidateableList<AgProgram> ProgramList { get; private set; }

		public ValidateableList<AgTimeReservation> TimeReservationList { get; private set; }
		public ValidateableList<AgKeywordReservation> KeywordReservationList { get; private set; }

		private Timer SecTimer { get; set; }
		private Process ReservationConsoleProcess { get; set; }
		private Process RealtimeConsoleProcess { get; set; }
		private string RealtimeFilename { get; set; }
		private string ReservationFilename { get; set; }
		private bool ReservationIsVideo { get; set; }
		private bool RealtimeIsVideo { get; set; }

		public bool IsRealtimeRecording => RealtimeConsoleProcess != null;

		public bool IsReservationRecording => ReservationConsoleProcess != null;

		public AgProgram NowProgram => ProgramList.Find(p => p.IsOnAir);

		/// <summary>
		/// 現在キーワード予約を開始する必要があるかどうか
		/// </summary>
		public bool NeedKeywordRecording
		{
			get
			{
				var isInclude =
					(from i in KeywordReservationList
					 where i.ConditionType == AgKeywordReservationConditionType.Inclued && (Regex.IsMatch(NowProgram.Title, i.Keyword) || Regex.IsMatch(NowProgram.Personality, i.Keyword))
					 select i).Count() != 0;

				var isExclude =
					(from i in KeywordReservationList
					 where i.ConditionType == AgKeywordReservationConditionType.Exclude && (Regex.IsMatch(NowProgram.Title, i.Keyword) || Regex.IsMatch(NowProgram.Personality, i.Keyword))
					 select i).Count() != 0;

				return isInclude && !isExclude;
			}
		}

		/// <summary>
		/// 他の予約と予約名の重複があるかどうか
		/// </summary>
		/// <param name="target">対象となるインスタンスの参照。この参照と一致した場合の重複を無視できます</param>
		public bool IsDuplicateNameReservation(string name, AgTimeReservation target)
		{
			return (from r in TimeReservationList where r.Name == name && !ReferenceEquals(r, target) select r).Count() != 0;
		}

		/// <summary>
		/// 他の予約と時間の重複があるかどうか
		/// </summary>
		/// <param name="target">対象となるインスタンスの参照。この参照と一致した場合の重複を無視できます</param>
		public bool IsDuplicateTimeReservation(TimeSpan start, TimeSpan end, AgTimeReservation target)
		{
			return (from r in TimeReservationList where r.StartTime < end && r.EndTime > start && !ReferenceEquals(r, target) select r).Count() != 0;
		}

		/// <summary>
		/// 他の予約と何らかの重複があるかどうか
		/// </summary>
		/// <param name="target">対象となるインスタンスの参照。この参照と一致した場合の重複を無視できます</param>
		public bool IsDuplicateReservation(string name, TimeSpan start, TimeSpan end, AgTimeReservation target)
		{
			return IsDuplicateTimeReservation(start, end, target) || IsDuplicateNameReservation(name, target);
		}

		private void CreateOutputDirectory()
		{
			var dir = $"./library/ag/";
			if (!Directory.Exists(dir))
				Directory.CreateDirectory(dir);
		}

		public void RecordSpecifiedTime(int specifiedTimeSec, string filename, bool isVideo, bool isRealtimeRecord)
		{
			StartRecord(filename, isVideo, isRealtimeRecord);
			Task.Delay(TimeSpan.FromSeconds(specifiedTimeSec)).Wait();
			StopRecord(isRealtimeRecord);
		}

		public void StartRecord(string filename, bool isVideo, bool isRealtimeRecord)
		{
			var tempFilename = isRealtimeRecord ? "temp_realtime" : "temp_reservation";

			CreateOutputDirectory();

			var process = ConsoleExecuter.StartOnConsole(
				$"rtmpdump -v -r \"rtmpe://fms1.uniqueradio.jp/\" -a ?rtmp://fms-base2.mitene.ad.jp/agqr/ -y aandg22 | ffmpeg -y -i pipe:0 ./library/ag/{tempFilename}.{(isVideo ? "mp4" : "mp3")}");

			if (isRealtimeRecord)
			{
				RealtimeFilename = filename;
				RealtimeConsoleProcess = process;
				RealtimeIsVideo = isVideo;
			}
			else
			{
				ReservationFilename = filename;
				ReservationConsoleProcess = process;
				ReservationIsVideo = isVideo;
			}

			OnRecordStarted(isRealtimeRecord);
		}

		public void StopRecord(bool isRealtimeRecord)
		{
			if (isRealtimeRecord)
			{
				if (RealtimeConsoleProcess != null)
				{
					ConsoleExecuter.StopConsole(RealtimeConsoleProcess);
					File.Move($"./library/ag/temp_realtime.{(RealtimeIsVideo ? "mp4" : "mp3")}", $"./library/ag/{Regex.Replace(RealtimeFilename, @"[\/:*?""<>|]+", i => " ")}.{(RealtimeIsVideo ? "mp4" : "mp3")}");
					OnRecordStopped(true);
					RealtimeConsoleProcess = null;
				}
			}
			else
			{
				if (ReservationConsoleProcess != null)
				{
					ConsoleExecuter.StopConsole(ReservationConsoleProcess);
					File.Move($"./library/ag/temp_reservation.{(ReservationIsVideo ? "mp4" : "mp3")}", $"./library/ag/{Regex.Replace(ReservationFilename, @"[\/:*?""<>|]+", i => " ")}.{(ReservationIsVideo ? "mp4" : "mp3")}");
					OnRecordStopped(false);
					ReservationConsoleProcess = null;
				}
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

		public event EventHandler<EventArgs<AgTimeReservation>> TimeReservationStarted;
		public void OnTimeReservationStarted(AgTimeReservation reservation)
		{
			TimeReservationStarted?.Invoke(this, new EventArgs<AgTimeReservation>(reservation));
		}

		public event EventHandler<EventArgs<AgTimeReservation>> TimeReservationStoped;
		public void OnTimeReservationStoped(AgTimeReservation reservation)
		{
			TimeReservationStoped?.Invoke(this, new EventArgs<AgTimeReservation>(reservation));
		}

		public event EventHandler<EventArgs<AgProgram>> KeywordReservationStarted;
		public void OnKeywordReservationStarted(AgProgram program)
		{
			KeywordReservationStarted?.Invoke(this, new EventArgs<AgProgram>(program));
		}

		public event EventHandler<EventArgs<AgProgram>> KeywordReservationStoped;
		public void OnKeywordReservationStoped(AgProgram program)
		{
			KeywordReservationStoped?.Invoke(this, new EventArgs<AgProgram>(program));
		}

		public event EventHandler ProgramTransitioned;
		public void OnProgramTransitioned()
		{
			ProgramTransitioned?.Invoke(this, new EventArgs());
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
					var titleElement = (from cls in classes where cls.Value == "title-p" select cls.Parent).First();

					var title = titleElement.Value;
					var url = titleElement.Element("a")?.Attribute("href").Value;
					var personality = (from cls in classes where cls.Value == "rp" select cls.Parent.Value).First();
					var hasVideo = (from cls in classes where cls.Value == "time" select cls.Parent).First()
						.Element("span")?.Elements("img")?.Attributes("src").ToList().Exists(att => att.Value == "http://cdn-agqr.joqr.jp/schedule/img/icon_m.gif") ?? false;

					var broadcastTypeStr = td.Attribute("class").Value;
					AgProgramBroadcastType broadcastType;
					switch (broadcastTypeStr)
					{
						case "bg-f":
							broadcastType = AgProgramBroadcastType.First;
							break;
						case "bg-l":
							broadcastType = AgProgramBroadcastType.Live;
							break;
						case "bg-repeat":
							broadcastType = AgProgramBroadcastType.Repeat;
							break;
						default:
							broadcastType = AgProgramBroadcastType.First;
							break;
					}

					programsWeek[weekIndex].Add(new AgProgram(Regex.Match(title, "([^\n]*)$").Groups[1].Value, time, time + lengthMin, personality, broadcastType, hasVideo, url != null ? new Uri(url) : null));
				}
			}

			// 曜日毎の番組リストを日数に換算して統合
			var res = new List<AgProgram>();
			foreach (var programs in programsWeek)
			{
				var weekDayIndex = programsWeek.IndexOf(programs);

				foreach (var program in programs)
				{
					// -- 日曜日から始まるようにする --

					// 曜日番号をそれぞれ +1 する
					program.StartTime = program.StartTime.Add(TimeSpan.FromDays(weekDayIndex + 1));

					// 曜日番号が7以上なら7日分減らす
					if (program.StartTime.Days >= 7)
						program.StartTime = program.StartTime.Subtract(TimeSpan.FromDays(7));

					program.EndTime = program.EndTime.Add(TimeSpan.FromDays(weekDayIndex + 1));

					if (program.EndTime.Days >= 7)
						program.EndTime = program.EndTime.Subtract(TimeSpan.FromDays(7));

					res.Add(program);
				}
			}

			// 時間順でソート
			res.Sort((x, y) => (int)(x.StartTime.TotalMinutes - y.StartTime.TotalMinutes));

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
