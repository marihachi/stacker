using System;

namespace Stacker.Model
{
	/// <summary>
	/// A&Gの番組を表します
	/// </summary>
	public class AgProgram
	{
		public AgProgram(string title, TimeSpan time, TimeSpan length, string personality, bool hasVideo)
		{
			Title = title;
			Time = time;
			Length = length;
			Personality = personality;
			HasVideo = hasVideo;
		}

		/// <summary>
		/// タイトルを取得します
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// 開始時間を取得します
		/// </summary>
		public TimeSpan Time { get; set; }

		/// <summary>
		/// 長さを取得します
		/// </summary>
		public TimeSpan Length { get; set; }

		/// <summary>
		/// パーソナリティを取得します
		/// </summary>
		public string Personality { get; set; }

		/// <summary>
		/// 動画として配信されるかどうかを示す値を取得します
		/// </summary>
		public bool HasVideo { get; set; }

		/// <summary>
		/// この番組が放送中かどうかを示す値を取得します
		/// </summary>
		public bool IsOnAir
		{
			get
			{
				var now = DateTime.Now;
				var nowTimeSpan = new TimeSpan((int)now.DayOfWeek, now.Hour, now.Minute, now.Second);

				return nowTimeSpan >= Time && nowTimeSpan <= Time + Length;
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
				Time == c.Time &&
				Length == c.Length &&
				Personality == c.Personality;
		}

		public override int GetHashCode()
		{
			return
				Title.GetHashCode() ^
				Time.GetHashCode() ^
				Length.GetHashCode() ^
				Personality.GetHashCode();
		}
	}
}
