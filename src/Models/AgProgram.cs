using Stacker.Models.Enums;
using System;

namespace Stacker.Models
{
	/// <summary>
	/// A&Gの番組を表します
	/// </summary>
	public class AgProgram
	{
		public AgProgram(string title, TimeSpan startTime, TimeSpan endTime, string personality, AgProgramBroadcastType broadcastType, bool hasVideo, Uri url = null)
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
		public AgProgramBroadcastType BroadcastType { get; set; }

		/// <summary>
		/// 動画として配信されるかどうかを示す値を取得します
		/// </summary>
		public bool HasVideo { get; set; }

		/// <summary>
		/// 
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

				if (StartTime > EndTime)
					return nowTimeSpan >= StartTime && nowTimeSpan <= TimeSpan.FromMinutes(23 * 60 + 59) || nowTimeSpan >= TimeSpan.FromMinutes(0) && nowTimeSpan <= EndTime; // 日を跨いだときの範囲
				else
					return nowTimeSpan >= StartTime && nowTimeSpan <= EndTime; // 通常の範囲
			}
		}

		public static bool operator ==(AgProgram c1, AgProgram c2)
		{
			return c1?.Equals(c2) ?? false;
		}

		public static bool operator !=(AgProgram c1, AgProgram c2)
		{
			return !(c1 == c2);
		}

		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
				return false;

			var c = (AgProgram)obj;
			return
				Title == c.Title &&
				StartTime == c.StartTime &&
				EndTime == c.EndTime &&
				Personality == c.Personality;
		}

		public override int GetHashCode()
		{
			return
				Title.GetHashCode() ^
				StartTime.GetHashCode() ^
				EndTime.GetHashCode() ^
				Personality.GetHashCode();
		}
	}
}
