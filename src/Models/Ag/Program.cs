using System;

namespace Stacker.Models.Ag
{
	/// <summary>
	/// 超！A＆G＋の番組を表します
	/// </summary>
	public class Program
	{
		public Program(string title, TimeSpan startTime, TimeSpan endTime, string personality, Enums.ProgramBroadcastType broadcastType, bool hasVideo, Uri url = null)
		{
			Title = title;
			StartTime = startTime;
			EndTime = endTime;
			Personality = personality;
			BroadcastType = broadcastType;
			HasVideo = hasVideo;
			Url = url;
		}

		/// <summary>
		/// タイトルを取得します
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// 開始時間を取得します
		/// </summary>
		public TimeSpan StartTime { get; set; }

		/// <summary>
		/// 終了時間を取得します
		/// </summary>
		public TimeSpan EndTime { get; set; }

		/// <summary>
		/// パーソナリティを取得します
		/// </summary>
		public string Personality { get; set; }

		/// <summary>
		/// 放送の種類を取得します
		/// </summary>
		public Enums.ProgramBroadcastType BroadcastType { get; set; }

		/// <summary>
		/// 動画として配信されるかどうかを示す値を取得します
		/// </summary>
		public bool HasVideo { get; set; }

		/// <summary>
		/// 番組サイトのURL
		/// </summary>
		public Uri Url { get; set; }

		/// <summary>
		/// この番組が放送中かどうかを示す値を取得します
		/// </summary>
		public bool IsOnAir
		{
			get
			{
				var now = DateTime.Now;
				var nowTimeSpan = new TimeSpan((int)now.DayOfWeek, now.Hour, now.Minute, now.Second);

				// 日を跨いだときの範囲を適用する必要がある
				if (StartTime > EndTime)
					return nowTimeSpan >= StartTime && nowTimeSpan <= TimeSpan.FromMinutes(23 * 60 + 59) || nowTimeSpan >= TimeSpan.FromMinutes(0) && nowTimeSpan <= EndTime;
				else
					return nowTimeSpan >= StartTime && nowTimeSpan <= EndTime;
			}
		}
	}
}
