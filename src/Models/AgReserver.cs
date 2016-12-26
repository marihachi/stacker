using Stacker.Models.Enums;
using Stacker.Models.EventArgses;
using Stacker.Utilities;
using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Stacker.Models
{
	/// <summary>
	/// 超！A＆G＋の配信を予約する機能を提供します
	/// </summary>
	public class AgReserver
	{
		public AgReserver(AgManager manager)
		{
			Manager = manager;

			AgTimeReservation targetTimeReservation = null;
			AgProgram targetKeywordReservationProgram = null;

			SecTimer = new Timer { Interval = 1000, Enabled = true };
			SecTimer.Tick += (s, ev) =>
			{
				var needRecordingTimeReservation = TimeReservationList.Find(i => i.NeedRecording);

				// 時間予約されている and 時間予約を完了する必要がある
				if (targetTimeReservation != null && !targetTimeReservation.NeedRecording)
				{
					// 時間予約終了
					Manager.ReservationRecorder.StopRecord();
					OnTimeReservationStoped(targetTimeReservation);
					targetTimeReservation = null;
				}

				// キーワード予約されている and (キーワード予約を完了する必要がある or 番組が遷移されている or (時間予約を開始する必要がある and 時間予約されてない))
				if (targetKeywordReservationProgram != null && (!NeedKeywordRecording || targetKeywordReservationProgram != Manager.NowProgram || (needRecordingTimeReservation != null && targetTimeReservation == null)))
				{
					// キーワード予約終了
					Manager.ReservationRecorder.StopRecord();
					OnKeywordReservationStoped(targetKeywordReservationProgram);
					targetKeywordReservationProgram = null;
				}

				// 時間予約されてない
				if (targetTimeReservation == null)
				{
					// 時間予約を開始する必要がある
					if (needRecordingTimeReservation != null)
					{
						// 時間予約開始
						Manager.ReservationRecorder.StartRecord($"{DateTime.Now.Year:0000}{DateTime.Now.Month:00}{DateTime.Now.Day:00}_{needRecordingTimeReservation.Name}", needRecordingTimeReservation.IsRecordVideo);
						OnTimeReservationStarted(needRecordingTimeReservation);
						targetTimeReservation = needRecordingTimeReservation;
					}

					// キーワード予約を開始する必要がある and キーワード予約されてない
					if (NeedKeywordRecording && targetKeywordReservationProgram == null)
					{
						// キーワード予約開始
						Manager.ReservationRecorder.StartRecord($"{DateTime.Now.Year:0000}{DateTime.Now.Month:00}{DateTime.Now.Day:00}_{Manager.NowProgram.Title}", Manager.NowProgram.HasVideo);
						OnKeywordReservationStarted(targetKeywordReservationProgram);
						targetKeywordReservationProgram = Manager.NowProgram;
					}
				}
			};

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

		#region Events

		public event EventHandler<EventArgs<AgTimeReservation>> TimeReservationStarted;

		public void OnTimeReservationStarted(AgTimeReservation reservation)
		{
			Debug.WriteLine("AgReserver: 時間予約を開始しました");
			TimeReservationStarted?.Invoke(this, new EventArgs<AgTimeReservation>(reservation));
		}

		public event EventHandler<EventArgs<AgTimeReservation>> TimeReservationStoped;

		public void OnTimeReservationStoped(AgTimeReservation reservation)
		{
			Debug.WriteLine("AgReserver: 時間予約を終了しました");
			TimeReservationStoped?.Invoke(this, new EventArgs<AgTimeReservation>(reservation));
		}

		public event EventHandler<EventArgs<AgProgram>> KeywordReservationStarted;

		public void OnKeywordReservationStarted(AgProgram program)
		{
			Debug.WriteLine("AgReserver: キーワード予約を開始しました");
			KeywordReservationStarted?.Invoke(this, new EventArgs<AgProgram>(program));
		}

		public event EventHandler<EventArgs<AgProgram>> KeywordReservationStoped;

		public void OnKeywordReservationStoped(AgProgram program)
		{
			Debug.WriteLine("AgReserver: キーワード予約を終了しました");
			KeywordReservationStoped?.Invoke(this, new EventArgs<AgProgram>(program));
		}

		#endregion Events

		#region Properties and getter methods

		private AgManager Manager { get; set; }

		private Timer SecTimer { get; set; }

		public ValidateableList<AgTimeReservation> TimeReservationList { get; private set; }

		public ValidateableList<AgKeywordReservation> KeywordReservationList { get; private set; }

		/// <summary>
		/// 現在キーワード予約を開始する必要があるかどうか
		/// </summary>
		public bool NeedKeywordRecording
		{
			get
			{
				if (Manager.NowProgram == null)
					return false;

				var isInclude =
					(from i in KeywordReservationList
					 where i.ConditionType == AgKeywordReservationConditionType.Include && (Regex.IsMatch(Manager.NowProgram.Title, i.Keyword) || Regex.IsMatch(Manager.NowProgram.Personality, i.Keyword))
					 select i).Count() != 0;

				var isExclude =
					(from i in KeywordReservationList
					 where i.ConditionType == AgKeywordReservationConditionType.Exclude && (Regex.IsMatch(Manager.NowProgram.Title, i.Keyword) || Regex.IsMatch(Manager.NowProgram.Personality, i.Keyword))
					 select i).Count() != 0;

				return isInclude && !isExclude;
			}
		}

		/// <summary>
		/// 他の予約と予約名の重複があるかどうか
		/// </summary>
		/// <param name="target">対象となるインスタンスの参照。この参照と一致した場合の重複を無視できます</param>
		public bool IsDuplicateNameReservation(string name, AgTimeReservation target) =>
			(from r in TimeReservationList where r.Name == name && !ReferenceEquals(r, target) select r).Count() != 0;

		/// <summary>
		/// 他の予約と時間の重複があるかどうか
		/// </summary>
		/// <param name="target">対象となるインスタンスの参照。この参照と一致した場合の重複を無視できます</param>
		public bool IsDuplicateTimeReservation(TimeSpan start, TimeSpan end, AgTimeReservation target) =>
			(from r in TimeReservationList where r.StartTime < end && r.EndTime > start && !ReferenceEquals(r, target) select r).Count() != 0;

		/// <summary>
		/// 他の予約と何らかの重複があるかどうか
		/// </summary>
		/// <param name="target">対象となるインスタンスの参照。この参照と一致した場合の重複を無視できます</param>
		public bool IsDuplicateReservation(string name, TimeSpan start, TimeSpan end, AgTimeReservation target) =>
			IsDuplicateTimeReservation(start, end, target) || IsDuplicateNameReservation(name, target);

		#endregion Properties and getter methods
	}
}
