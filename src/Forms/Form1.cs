using Stacker.Utilities;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stacker.Forms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public CultureInfo Culture { get; set; } = new CultureInfo("ja-JP");
		public Models.Ag.Manager Ag { get; set; }

		private void Status(string text)
		{
			toolStripStatusLabel1.Text = text;
		}

		/*
		private async Task DownloadAndExtractFileAsync(string downloadUrl, string filename, string output = null)
		{
			Status($"{output ?? filename}をダウンロードしています...");
			var client = new HttpClient();
			var res = await client.GetAsync(downloadUrl);
			using (var zipStream = await res.Content.ReadAsStreamAsync())
			{
				Status($"{output}を展開しています...");
				var zip = new ZipArchive(zipStream);
				var zipEntry = zip.GetEntry(filename);
				using (var stream = zipEntry.Open())
				using (var fs = new FileStream(output ?? filename, FileMode.OpenOrCreate))
				{
					stream.CopyTo(fs);
				}
			}
			Status("準備完了");
		}
		*/

		private async Task UpdateProgramsAsync()
		{
			Status("超！A＆G＋ の番組表を更新しています...");

			try
			{
				var cts = new CancellationTokenSource();
				cts.CancelAfter(TimeSpan.FromSeconds(5));
				await Task.Run(() => Ag.UpdateProgramList(), cts.Token);
			}
			catch (TaskCanceledException)
			{
				Status("番組表の更新に失敗しました");
			}

			Status("準備完了");
		}

		private string FormatTime(TimeSpan time)
		{
			return $"{Culture.DateTimeFormat.GetAbbreviatedDayName((DayOfWeek)time.Days)}{time.Hours:00}:{time.Minutes:00}";
		}

		private void UpdateForm()
		{
			Status("画面を更新しています...");

			// ag program reservation listView

			agProgramListView.Items.Clear();
			foreach (var program in Ag.ProgramList)
			{
				var broadcastType = "";
				Color backColor = Color.White;
				Color foreColor = Color.Black;
				if (program.BroadcastType == Models.Ag.Enums.ProgramBroadcastType.First)
				{
					broadcastType = "初回放送";
					backColor = Color.FromArgb(255, 200, 200);
				}
				else if (program.BroadcastType == Models.Ag.Enums.ProgramBroadcastType.Repeat)
				{
					broadcastType = "リピート放送";
				}
				else if (program.BroadcastType == Models.Ag.Enums.ProgramBroadcastType.Live)
				{
					broadcastType = "生放送";
					backColor = Color.FromArgb(164, 255, 187);
				}

				var listViewItem = new ListViewItem(new string[] { $"{FormatTime(program.StartTime)} - {FormatTime(program.EndTime)}", program.Title, program.Personality, broadcastType, program.HasVideo ? "有" : "無" });
				listViewItem.BackColor = backColor;
				listViewItem.ForeColor = foreColor;
				listViewItem.Tag = program;
				agProgramListView.Items.Add(listViewItem);
			}

			// ag time reservation listView

			agTimeReservationListView.Items.Clear();
			foreach (var reservation in Ag.Reserver.TimeReservationList)
			{
				var listViewItem = new ListViewItem(new string[] { FormatTime(reservation.StartTime), FormatTime(reservation.EndTime), reservation.Name });
				listViewItem.Tag = reservation;
				agTimeReservationListView.Items.Add(listViewItem);
			}

			// ag keyword reservation listview

			agKeywordReservationListView.Items.Clear();
			foreach (var reservation in Ag.Reserver.KeywordReservationList)
			{
				var listViewItem = new ListViewItem(new string[] { reservation.ConditionType.ToString(), reservation.Keyword });
				listViewItem.Tag = reservation;
				agKeywordReservationListView.Items.Add(listViewItem);
			}

			// toolbar

			//agProgramLabel.Text = $"番組: {Ag.NowProgram?.Title ?? "未取得"}";
			//agPersonalityLabel.Text = $"パーソナリティ: {Ag.NowProgram?.Personality ?? "未取得"}";

			// main menu



			Status("準備完了");
		}

		#region EventHandlers

		//
		// general
		//

		private async void Form1_Load(object sender, EventArgs e)
		{
			Status("初期化しています...");

			var title = Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyTitleAttribute)) as AssemblyTitleAttribute;
			Text = string.Format(Text, title.Title);

			if (!File.Exists("rtmpdump.exe"))
			{
				// await DownloadAndExtractFileAsync("https://rtmpdump.mplayerhq.hu/download/rtmpdump-2.4-git-010913-windows.zip", "rtmpdump.exe");
				MessageBox.Show("rtmpdump.exeが見つかりません", "エラー");
				Close();
				return;
			}

			if (!File.Exists("ffmpeg.exe"))
			{
				// await DownloadAndExtractFileAsync("https://ffmpeg.zeranoe.com/builds/win32/static/ffmpeg-latest-win32-static.zip", "ffmpeg-latest-win32-static/bin/ffmpeg.exe", "ffmpeg.exe");
				MessageBox.Show("ffmpeg.exeが見つかりません", "エラー");
				Close();
				return;
			}

			Ag = new Models.Ag.Manager();

			await UpdateProgramsAsync();
			UpdateForm();

			var comp = new ListViewItemComparer();
			comp.ColumnModes = new ListViewItemComparer.ComparerMode[]
			{
					ListViewItemComparer.ComparerMode.String,
					ListViewItemComparer.ComparerMode.String,
					ListViewItemComparer.ComparerMode.String
			};
			agTimeReservationListView.ListViewItemSorter = comp;

			var comp2 = new ListViewItemComparer();
			comp2.ColumnModes = new ListViewItemComparer.ComparerMode[]
			{
					ListViewItemComparer.ComparerMode.String,
					ListViewItemComparer.ComparerMode.String
			};
			agKeywordReservationListView.ListViewItemSorter = comp2;

			Ag.RealtimeRecorder.RecordStarted += (s, ev) =>
			{
				Status($"「{ev.Data}」の録音が開始されました");
			};

			Ag.RealtimeRecorder.RecordStopped += (s, ev) =>
			{
				Status($"「{ev.Data}」の録音が完了しました");
			};

			Ag.ProgramTransitioned += (s, ev) =>
			{
				agProgramLabel.Text = $"番組: {Ag.NowProgram?.Title?.Trim() ?? "未取得"}";
				agPersonalityLabel.Text = $"パーソナリティ: {Ag.NowProgram?.Personality?.Trim() ?? "未取得"}";
			};

			Ag.Reserver.KeywordReservationStarted += (s, ev) =>
			{
				Status($"キーワード予約「{ev.Data.Title}」が開始されました");
			};

			Ag.Reserver.KeywordReservationStoped += (s, ev) =>
			{
				Status($"キーワード予約「{ev.Data.Title}」が完了しました");
			};

			Ag.Reserver.TimeReservationStarted += (s, ev) =>
			{
				Status($"時間予約「{ev.Data.Name}」が開始されました");
			};

			Ag.Reserver.TimeReservationStoped += (s, ev) =>
			{
				Status($"時間予約「{ev.Data.Name}」が完了しました");
			};

			Status("準備完了");
		}

		//
		// main menu file
		//

		private void exitMainMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		//
		// main menu view
		//

		private void updateDisplayMenuItem_Click(object sender, EventArgs e)
		{
			UpdateForm();
		}

		//
		// main menu setting
		//

		private void keywordReservationVideoModeMainMenuItem_Click(object sender, EventArgs e)
		{
			foreach (var item in new[] { 動画モード自動ToolStripMenuItem, 動画モードありToolStripMenuItem, 動画モードなしToolStripMenuItem })
			{
				if (ReferenceEquals(item, sender))
					item.CheckState = CheckState.Indeterminate;
				else
					item.CheckState = CheckState.Unchecked;
			}
		}

		private void settingsInportExportMainMenuItem_Click(object sender, EventArgs e)
		{
			// TODO: 設定のインポートとエクスポート ダイアログの表示
		}

		//
		// main menu help
		//

		private void issuesMainMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("https://github.com/marihachi/stacker/issues");
		}

		private void versionMainMenuItem_Click(object sender, EventArgs e)
		{
			var asmInfo = Assembly.GetExecutingAssembly().GetName();
			MessageBox.Show($"ver.{asmInfo.Version.ToString(4)}", $"{asmInfo.Name}のバージョン情報");
		}

		//
		// ag toolbar
		//

		private void agStartRecordButton_Click(object sender, EventArgs e)
		{
			Ag.RealtimeRecorder.StartRecord($"realtime_{DateTime.Now.ToFileTime()}", agEnableVideoRealtimeMainMenuItem.Checked);
		}

		private void agStopRecordButton_Click(object sender, EventArgs e)
		{
			Task.Run(() => Ag.RealtimeRecorder.StopRecord());
		}

		private void agRecordSpecifiedTimeButton_Click(object sender, EventArgs e)
		{
			var dialog = new AgRecordSpecifiedTimeSettingDialog();
			dialog.ShowDialog();

			if (dialog.DialogResult == DialogResult.OK)
				Task.Run(() => Ag.RealtimeRecorder.RecordSpecifiedTime(60 * dialog.Length, $"realtime_{DateTime.Now.ToFileTime()}", agEnableVideoRealtimeMainMenuItem.Checked));
		}

		private async void agUpdateProgramListButton_Click(object sender, EventArgs e)
		{
			await UpdateProgramsAsync();
			UpdateForm();
		}

		private void agOpenLibraryDirectoryButton_Click(object sender, EventArgs e)
		{
			Process.Start(".\\library\\ag");
		}

		//
		// agProgramListView
		//

		private void agProgramListViewMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (e.Cancel = agProgramListView.SelectedItems.Count == 0)
				return;

			var program = (Models.Ag.Program)agProgramListView.SelectedItems[0].Tag;

			agDisplayProgramPageProgramListViewMenuItem.Enabled = program.Url != null;
		}

		private void agTimeReservateProgramListViewMenuItem_Click(object sender, EventArgs e)
		{
			var program = (Models.Ag.Program)agProgramListView.SelectedItems[0].Tag;
			var reservation = new Models.Ag.TimeReservation(program.Title, program.HasVideo, program.StartTime, program.EndTime, Ag);

			var dialog = new AgTimeReservationSettingDialog(reservation);
			dialog.ShowDialog();

			if (dialog.DialogResult == DialogResult.OK)
			{
				try
				{
					Ag.Reserver.TimeReservationList.Add(reservation);
				}
				catch (InvalidOperationException ex)
				{
					throw new ApplicationException("予約の追加に失敗しました。", ex);
				}
				var listViewItem = new ListViewItem(new string[] { FormatTime(reservation.StartTime), FormatTime(reservation.EndTime), reservation.Name });
				listViewItem.Tag = reservation;
				agTimeReservationListView.Items.Add(listViewItem);
			}
		}

		private void agDisplayProgramPageProgramListViewMenuItem_Click(object sender, EventArgs e)
		{
			var program = (Models.Ag.Program)agProgramListView.SelectedItems[0].Tag;

			Process.Start(program.Url.ToString());
		}

		private void agProgramListView_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
				return;

			agTimeReservateProgramListViewMenuItem_Click(this, null);
		}

		//
		// agTimeReservationMenu
		//

		private void agTimeReservationMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			var isSelected = agTimeReservationListView.SelectedItems.Count != 0;

			agAddTimeReservationMenuItem.Enabled = !isSelected;
			agEditTimeReservationMenuItem.Enabled = isSelected;
			agDeleteTimeReservationMenuItem.Enabled = isSelected;
		}

		private void agAddTimeReservationMenuItem_Click(object sender, EventArgs e)
		{
			var dialog = new AgTimeReservationSettingDialog(new Models.Ag.TimeReservation("無題", false, TimeSpan.FromMinutes(0), TimeSpan.FromMinutes(30), Ag));
			dialog.ShowDialog();

			if (dialog.DialogResult == DialogResult.OK)
			{
				try
				{
					Ag.Reserver.TimeReservationList.Add(dialog.Reservation);
				}
				catch (InvalidOperationException ex)
				{
					throw new ApplicationException("予約の追加に失敗しました。", ex);
				}

				var item = new ListViewItem(new string[] { FormatTime(dialog.Reservation.StartTime), FormatTime(dialog.Reservation.EndTime), dialog.Reservation.Name });
				item.Tag = dialog.Reservation;
				agTimeReservationListView.Items.Add(item);
				agTimeReservationListView.Sort();
			}
		}

		private void agEditTimeReservationMenuItem_Click(object sender, EventArgs e)
		{
			var listViewItem = agTimeReservationListView.SelectedItems[0];
			var reservation = (Models.Ag.TimeReservation)listViewItem.Tag;

			var dialog = new AgTimeReservationSettingDialog(reservation);
			dialog.ShowDialog();

			if (dialog.DialogResult == DialogResult.OK)
			{
				var item = new ListViewItem(new string[] { FormatTime(reservation.StartTime), FormatTime(reservation.EndTime), reservation.Name });
				item.Tag = reservation;

				agTimeReservationListView.Items[agTimeReservationListView.Items.IndexOf(listViewItem)] = item;
			}
		}

		private void agDeleteTimeReservationMenuItem_Click(object sender, EventArgs e)
		{
			var listViewItem = agTimeReservationListView.SelectedItems[0];
			var reservation = (Models.Ag.TimeReservation)listViewItem.Tag;

			if (reservation.NeedRecording)
				Ag.ReservationRecorder.StopRecord();

			agTimeReservationListView.Items.Remove(listViewItem);
			Ag.Reserver.TimeReservationList.Remove(reservation);
		}

		//
		// agTimeReservationListView
		//

		private void agTimeReservationListView_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
				return;

			agEditTimeReservationMenuItem_Click(this, null);
		}

		//
		// agKeywordReservationMenu
		//

		private void agKeywordReservationMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			var isSelected = agKeywordReservationListView.SelectedItems.Count != 0;

			agAddKeywordReservationMenuItem.Enabled = !isSelected;
			agEditKeywordReservationMenuItem.Enabled = isSelected;
			agDeleteKeywordReservationMenuItem.Enabled = isSelected;
		}

		private void agAddKeywordReservationMenuItem_Click(object sender, EventArgs e)
		{
			var dialog = new AgKeywordReservationSettingDialog(new Models.Ag.KeywordReservation(Models.Ag.Enums.KeywordReservationConditionType.Include, "", Ag));
			dialog.ShowDialog();

			if (dialog.DialogResult == DialogResult.OK)
			{
				try
				{
					Ag.Reserver.KeywordReservationList.Add(dialog.Reservation);
				}
				catch (InvalidOperationException ex)
				{
					throw new ApplicationException("予約の追加に失敗しました。", ex);
				}

				var item = new ListViewItem(new string[] { dialog.Reservation.ConditionType.ToString(), dialog.Reservation.Keyword });
				item.Tag = dialog.Reservation;
				agKeywordReservationListView.Items.Add(item);
				agKeywordReservationListView.Sort();
			}
		}

		private void agEditKeywordReservationMenuItem_Click(object sender, EventArgs e)
		{
			var listViewItem = agKeywordReservationListView.SelectedItems[0];
			var reservation = (Models.Ag.KeywordReservation)listViewItem.Tag;

			var dialog = new AgKeywordReservationSettingDialog(reservation);
			dialog.ShowDialog();

			if (dialog.DialogResult == DialogResult.OK)
			{
				var item = new ListViewItem(new string[] { dialog.Reservation.ConditionType.ToString(), dialog.Reservation.Keyword });
				item.Tag = reservation;

				agKeywordReservationListView.Items[agKeywordReservationListView.Items.IndexOf(listViewItem)] = item;
			}
		}

		private void agDeleteKeywordReservationMenuItem_Click(object sender, EventArgs e)
		{
			var listViewItem = agKeywordReservationListView.SelectedItems[0];
			var reservation = (Models.Ag.KeywordReservation)listViewItem.Tag;

			if (reservation.Manager.Reserver.NeedKeywordRecording)
				Ag.ReservationRecorder.StopRecord();

			agKeywordReservationListView.Items.Remove(listViewItem);
			Ag.Reserver.KeywordReservationList.Remove(reservation);
		}

		//
		// agKeywordReservationListView
		//

		private void agKeywordReservationListView_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
				return;

			agEditKeywordReservationMenuItem_Click(this, null);
		}

		#endregion eventHandlers

		private void agTimeReservationListView_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			//クリックされた列を設定
			(agTimeReservationListView.ListViewItemSorter as ListViewItemComparer).Column = e.Column;
			//並び替える
			agTimeReservationListView.Sort();
		}

		private void agKeywordReservationListView_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			//クリックされた列を設定
			(agKeywordReservationListView.ListViewItemSorter as ListViewItemComparer).Column = e.Column;
			//並び替える
			agKeywordReservationListView.Sort();
		}
	}
}
