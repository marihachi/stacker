using System;

namespace Stacker.Models
{
	/// <summary>
	/// A&Gの時間ベース予約情報を表します
	/// </summary>
	public class AgTimeReservation : ICloneable
	{
		private AgTimeReservation(AgTimeReservation timeReservation)
		{
			Name = timeReservation.Name;
			StartTime = timeReservation.StartTime;
			EndTime = timeReservation.EndTime;
			IsEveryWeek = timeReservation.IsEveryWeek;
		}

		public AgTimeReservation(string name, TimeSpan startTime, TimeSpan endTime, bool isEveryWeek)
		{
			Name = name;
			StartTime = startTime;
			EndTime = endTime;
			IsEveryWeek = isEveryWeek;
		}

		/// <summary>
		/// 名前を取得または設定します
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// 開始時刻を取得または設定します
		/// </summary>
		public TimeSpan StartTime { get; set; }

		/// <summary>
		/// 開始時刻を取得または設定します
		/// </summary>
		public TimeSpan EndTime { get; set; }

		/// <summary>
		/// 毎週予約を行うかどうかを示す値を取得または設定します
		/// </summary>
		public bool IsEveryWeek { get; set; }

		/// <summary>
		/// 現在予約する必要のある範囲に含まれているかどうか
		/// </summary>
		public bool IsInRange
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

		public object Clone()
		{
			return new AgTimeReservation(this);
		}
	}
}
