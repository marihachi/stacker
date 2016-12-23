using System;

namespace Stacker.Models
{
	public abstract class AgReservation
	{
		public AgReservation(string name, bool isRecordVideo)
		{
			Name = name;
			IsRecordVideo = isRecordVideo;
		}

		/// <summary>
		/// 名前を取得または設定します
		/// </summary>
		public string Name { get; set; }

		public bool IsRecordVideo { get; set; }

		public abstract bool NeedStartRecording { get; }
	}

	/// <summary>
	/// A&Gの時間ベース予約情報を表します
	/// </summary>
	public class AgTimeReservation : AgReservation
	{
		public AgTimeReservation(string name, bool isRecordVideo, TimeSpan startTime, TimeSpan endTime)
			: base(name, isRecordVideo)
		{
			StartTime = startTime;
			EndTime = endTime;
		}

		/// <summary>
		/// 開始時刻を取得または設定します
		/// </summary>
		public TimeSpan StartTime { get; set; }

		/// <summary>
		/// 開始時刻を取得または設定します
		/// </summary>
		public TimeSpan EndTime { get; set; }

		/// <summary>
		/// 予約のレコードを開始する必要があるかどうか
		/// </summary>
		public override bool NeedStartRecording
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
	}

	public class AgKeywordReservation : AgReservation
	{
		public AgKeywordReservation(string name, bool isRecordVideo)
			: base(name, isRecordVideo)
		{

		}

		public override bool NeedStartRecording { get; }
	}
}
