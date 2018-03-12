using Codeplex.Data;
using System;

namespace Stacker.Models.Ag
{
	public abstract class Reservation
	{
		public Reservation(Manager manager)
		{
			Manager = manager;
		}

		public Manager Manager { get; set; }

		public abstract object Serialize();
	}

	/// <summary>
	/// A&Gの時間ベース予約情報を表します
	/// </summary>
	public class TimeReservation : Reservation
	{
		public TimeReservation(string name, bool isRecordVideo, TimeSpan startTime, TimeSpan endTime, Manager manager)
			: base(manager)
		{
			Name = name;
			IsRecordVideo = isRecordVideo;
			StartTime = startTime;
			EndTime = endTime;
		}

		public TimeReservation(string jsonString, Manager manager)
			: base(manager)
		{
			var j = DynamicJson.Parse(jsonString);

			Name = (string)j.name;
			IsRecordVideo = (bool)j.is_record_video;
			StartTime = TimeSpan.FromMinutes((int)j.start_time);
			EndTime = TimeSpan.FromMinutes((int)j.end_time);
		}

		/// <summary>
		/// 名前を取得または設定します
		/// </summary>
		public string Name { get; set; }

		public bool IsRecordVideo { get; set; }

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
		public bool NeedRecording
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

		/// <summary>
		/// Jsonにシリアライズします
		/// </summary>
		/// <returns></returns>
		public override object Serialize()
		{
			var data = new {
				name = Name,
				is_record_video = IsRecordVideo,
				start_time = StartTime.TotalMinutes,
				end_time = EndTime.TotalMinutes
			};

			return data;
		}
	}

	/// <summary>
	/// A&Gのキーワードベース予約情報を表します
	/// </summary>
	public class KeywordReservation : Reservation
	{
		public KeywordReservation(Enums.KeywordReservationConditionType conditionType, string keyword, Manager manager)
			: base(manager)
		{
			ConditionType = conditionType;
			Keyword = keyword;
		}

		public KeywordReservation(string jsonString, Manager manager)
			: base(manager)
		{
			var j = DynamicJson.Parse(jsonString);

			ConditionType = (Enums.KeywordReservationConditionType)j.condition_type;
			Keyword = (string)j.keyword;
		}

		/// <summary>
		/// 条件の種類
		/// </summary>
		public Enums.KeywordReservationConditionType ConditionType { get; set; }

		/// <summary>
		/// キーワード
		/// </summary>
		public string Keyword { get; set; }

		/// <summary>
		/// Jsonにシリアライズします
		/// </summary>
		/// <returns></returns>
		public override object Serialize()
		{
			var data = new
			{
				condition_type = (int)ConditionType,
				keyword = Keyword
			};

			return data;
		}
	}
}
