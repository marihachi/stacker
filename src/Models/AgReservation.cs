using Stacker.Models.Enums;
using System;
using System.Text.RegularExpressions;

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

		public abstract bool NeedRecording { get; }
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
		/// 現在レコードを開始する必要があるかどうか
		/// </summary>
		public override bool NeedRecording
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

	/// <summary>
	/// A&Gのキーワードベース予約情報を表します
	/// </summary>
	public class AgKeywordReservation : AgReservation
	{
		public AgKeywordReservation(string name, bool isRecordVideo, AgManager manager)
			: base(name, isRecordVideo)
		{
			Manager = manager;
		}

		private AgManager Manager { get; set; }

		/// <summary>
		/// 条件の種類
		/// </summary>
		public AgKeywordReservationConditionType ConditionType { get; set; }

		/// <summary>
		/// キーワード
		/// </summary>
		public string Keyword { get; set; }

		/// <summary>
		/// 現在レコードを開始する必要があるかどうか
		/// </summary>
		public override bool NeedRecording
		{
			get
			{
				return
					(ConditionType == AgKeywordReservationConditionType.Inclued) == Regex.IsMatch(Manager.NowProgram.Title, Keyword) ||
					(ConditionType == AgKeywordReservationConditionType.Inclued) == Regex.IsMatch(Manager.NowProgram.Personality, Keyword);
			}
		}
	}
}
