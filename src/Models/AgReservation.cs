using Codeplex.Data;
using Stacker.Models.Enums;
using System;

namespace Stacker.Models
{
	public abstract class AgReservation
	{
		public AgReservation(AgManager manager)
		{
			Manager = manager;
		}

		public AgManager Manager { get; set; }

		public abstract object Serialize();
	}

	/// <summary>
	/// A&Gの時間ベース予約情報を表します
	/// </summary>
	public class AgTimeReservation : AgReservation
	{
		public AgTimeReservation(string name, bool isRecordVideo, TimeSpan startTime, TimeSpan endTime, AgManager manager)
			: base(manager)
		{
			Name = name;
			IsRecordVideo = isRecordVideo;
			StartTime = startTime;
			EndTime = endTime;
		}

		public AgTimeReservation(string jsonString, AgManager manager)
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
	public class AgKeywordReservation : AgReservation
	{
		public AgKeywordReservation(AgKeywordReservationConditionType conditionType, string keyword, AgManager manager)
			: base(manager)
		{
			ConditionType = conditionType;
			Keyword = keyword;
		}

		public AgKeywordReservation(string jsonString, AgManager manager)
			: base(manager)
		{
			var j = DynamicJson.Parse(jsonString);

			ConditionType = (AgKeywordReservationConditionType)j.condition_type;
			Keyword = (string)j.keyword;
		}

		/// <summary>
		/// 条件の種類
		/// </summary>
		public AgKeywordReservationConditionType ConditionType { get; set; }

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
