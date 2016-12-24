using Codeplex.Data;
using Stacker.Models.Enums;
using Stacker.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Stacker.Models
{
	/// <summary>
	/// 超！A＆G＋に関する管理の機能を提供します
	/// </summary>
	public class AgManager : IDisposable
	{
		public AgManager()
		{
			AgProgram lastCheckProgram = null;

			SecTimer = new Timer { Interval = 1000, Enabled = true };
			SecTimer.Tick += (s, ev) =>
			{
				if (lastCheckProgram != NowProgram)
				{
					lastCheckProgram = NowProgram;
					OnProgramTransitioned();
				}
			};

			ProgramList = new ValidateableList<AgProgram>(i => i != null);

			Reserver = new AgReserver(this);

			Load();
		}

		#region Events

		public event EventHandler ProgramTransitioned;

		public void OnProgramTransitioned() =>
			ProgramTransitioned?.Invoke(this, new EventArgs());

		#endregion Events

		#region Properties and getter methods

		private Timer SecTimer { get; set; }

		public Uri ProgramListUrl { get; set; } = new Uri("http://www.agqr.jp/timetable/streaming.html");

		public ValidateableList<AgProgram> ProgramList { get; private set; }

		public AgProgram NowProgram => ProgramList.Find(p => p.IsOnAir);

		public AgRecorder RealtimeRecorder { get; set; } = new AgRecorder("realtime");

		public AgRecorder ReservationRecorder { get; set; } = new AgRecorder("reservation");

		public AgReserver Reserver { get; set; }

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

		#endregion Properties and getter methods

		#region Action methods

		/// <summary>
		/// 番組表情報を再取得します
		/// </summary>
		public void UpdateProgramList()
		{
			ProgramList.Clear();
			ProgramList.AddRange(AnalyzeProgramList());
		}

		public void Load()
		{
			string src;

			if (!File.Exists("ag.dat"))
				return;

			using (var sr = new StreamReader("ag.dat"))
				src = sr.ReadToEnd();

			if (string.IsNullOrEmpty(src))
				return;

			var j = DynamicJson.Parse(src);

			foreach(var timeReservation in j.time_reservations)
			{
				Reserver?.TimeReservationList.Add(new AgTimeReservation(timeReservation.ToString(), this));
			}

			foreach (var keywordReservation in j.keyword_reservations)
			{
				Reserver?.KeywordReservationList.Add(new AgKeywordReservation(keywordReservation.ToString(), this));
			}
		}

		public void Save()
		{
			dynamic j = new DynamicJson();

			j.time_reservations = from r in Reserver.TimeReservationList select r.Serialize();
			j.keyword_reservations = from r in Reserver.KeywordReservationList select r.Serialize();

			using (var sw = new StreamWriter("ag.dat"))
				sw.Write(j.ToString());
		}

		public void Dispose()
		{
			ReservationRecorder.Dispose();
			RealtimeRecorder.Dispose();

			Save();
		}

		#endregion Action methods
	}
}
