﻿using Stacker.Models;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Reflection;
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
		public AgManager Ag { get; set; }

		private void Status(string text)
		{
			toolStripStatusLabel1.Text = text;
		}

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

		private async Task UpdateProgramsAsync()
		{
			Status("超！A＆G＋ の番組表を更新しています...");

			await Task.Run(() => Ag.UpdateProgramList());

			Status("準備完了");
		}

		private string FormatTime(TimeSpan time)
		{
			return $"{Culture.DateTimeFormat.GetAbbreviatedDayName((DayOfWeek)time.Days)}{time.Hours:00}:{time.Minutes:00}";
		}

		private void UpdateForm()
		{
			Status("画面を更新しています...");

			agProgramListView.Items.Clear();
			foreach (var program in Ag.ProgramList)
			{
				var broadcastType = "";
				Color backColor;
				Color foreColor;
				if (program.BroadcastType == Models.Enums.AgProgramBroadcastType.First)
				{
					broadcastType = "初回放送";
					backColor = Color.FromArgb(255, 200, 200);
					foreColor = Color.Black;
				}
				else if (program.BroadcastType == Models.Enums.AgProgramBroadcastType.Repeat)
				{
					broadcastType = "リピート放送";
					backColor = Color.FromArgb(230, 230, 230);
					foreColor = Color.Black;
				}
				else if (program.BroadcastType == Models.Enums.AgProgramBroadcastType.Live)
				{
					broadcastType = "生放送";
					backColor = Color.FromArgb(164, 255, 187);
					foreColor = Color.Black;
				}
				else
				{
					backColor = Color.White;
					foreColor = Color.Black;
				}

				var listViewItem = new ListViewItem(new string[] { $"{FormatTime(program.StartTime)} - {FormatTime(program.EndTime)}", program.Title, program.Personality, broadcastType, program.HasVideo ? "有" : "無" });
				listViewItem.BackColor = backColor;
				listViewItem.ForeColor = foreColor;
				listViewItem.Tag = program;
				agProgramListView.Items.Add(listViewItem);
			}

			agTimeReservationListView.Items.Clear();
			foreach (var reservation in Ag.ReservationList)
			{
				var listViewItem = new ListViewItem(new string[] { FormatTime(reservation.StartTime), FormatTime(reservation.EndTime), reservation.Name });
				listViewItem.Tag = reservation;
				agTimeReservationListView.Items.Add(listViewItem);
			}

			agProgramLabel.Text = $"番組: {Ag.NowProgram?.Title ?? "未取得"}";
			agPersonalityLabel.Text = $"パーソナリティ: {Ag.NowProgram?.Personality ?? "未取得"}";


			Status("準備完了");
		}

		#region EventHandlers

		//
		// general
		//

		private async void Form1_Load(object sender, EventArgs e)
		{
			Status("初期化しています...");
			var asmInfo = Assembly.GetExecutingAssembly().GetName();
			Text = string.Format(Text, asmInfo.Name, asmInfo.Version.ToString(3));

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

			Ag = new AgManager();

			await UpdateProgramsAsync();
			UpdateForm();

			Ag.RecordStarted += (s, ev) =>
			{
				Status($"「{ev.Filename}」の録音が開始されました");
			};

			Ag.RecordStopped += (s, ev) =>
			{
				Status($"「{ev.Filename}」の録音が完了しました");
			};

			Ag.ProgramTransitioned += (s, ev) =>
			{
				agProgramLabel.Text = $"番組: {Ag.NowProgram?.Title ?? "未取得"}";
				agPersonalityLabel.Text = $"パーソナリティ: {Ag.NowProgram?.Personality ?? "未取得"}";
			};

			Ag.ReservationStarted += (s, ev) =>
			{
				Status($"時間予約「{ev.Data.Name}」が開始されました");
			};

			Ag.ReservationStoped += (s, ev) =>
			{
				Status($"時間予約「{ev.Data.Name}」が完了しました");
			};

			Status("準備完了");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start(".\\library\\ag");
		}

		//
		// main menu view
		//

		private async void agUpdateProgramListMenuItem_Click(object sender, EventArgs e)
		{
			await UpdateProgramsAsync();
			UpdateForm();
		}

		private void updateDisplayMenuItem_Click(object sender, EventArgs e)
		{
			UpdateForm();
		}

		//
		// main menu help
		//

		private void versionMainMenuItem_Click(object sender, EventArgs e)
		{
			var asmInfo = Assembly.GetExecutingAssembly().GetName();
			MessageBox.Show($"ver.{asmInfo.Version.ToString(3)}", $"{asmInfo.Name}のバージョン情報");
		}

		//
		// ag toolbar
		//

		private void agStartRecordButton_Click(object sender, EventArgs e)
		{
			Ag.StartRecord($"realtime_{DateTime.Now.ToFileTime()}", agEnableVideoRealtimeMainMenuItem.Checked, true);
		}

		private void agStopRecordButton_Click(object sender, EventArgs e)
		{
			Task.Run(() => Ag.StopRecord(true));
		}

		private void agRecordSpecifiedTimeButton_Click(object sender, EventArgs e)
		{
			var dialog = new agRecordSpecifiedTimeSettingDialog();
			dialog.ShowDialog();

			if (dialog.DialogResult == DialogResult.OK)
				Task.Run(() => Ag.RecordSpecifiedTime((int)(60 * dialog.Length), $"realtime_{DateTime.Now.ToFileTime()}", agEnableVideoRealtimeMainMenuItem.Checked, true));
		}

		//
		// agProgramListView
		//

		private void agProgramListViewMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (e.Cancel = agProgramListView.SelectedItems.Count == 0)
				return;

			var program = (AgProgram)agProgramListView.SelectedItems[0].Tag;

			agDisplayProgramPageProgramListViewMenuItem.Enabled = program.Url != null;
		}

		private void agTimeReservateProgramListViewMenuItem_Click(object sender, EventArgs e)
		{
			var program = (AgProgram)agProgramListView.SelectedItems[0].Tag;
			var reservation = new AgTimeReservation(program.Title, program.HasVideo, program.StartTime, program.EndTime, true);

			var dialog = new AgTimeReservationSettingDialog(reservation, Ag);
			dialog.ShowDialog();

			if (dialog.DialogResult == DialogResult.OK)
			{
				try
				{
					Ag.ReservationList.Add(reservation);
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
			var program = (AgProgram)agProgramListView.SelectedItems[0].Tag;

			Process.Start(program.Url.ToString());
		}

		private void agProgramListView_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
				return;

			agTimeReservateProgramListViewMenuItem_Click(this, null);
		}

		//
		// agTimeReservationListViewMenu
		//

		private void agTimeReservationListViewMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			var isSelected = agTimeReservationListView.SelectedItems.Count != 0;

			agEditTimeReservationListMenuItem.Enabled = isSelected;
			toolStripSeparator3.Enabled = isSelected;
			agDeleteTimeReservationListMenuItem.Enabled = isSelected;

			agAddTimeReservationListMenuItem.Enabled = !isSelected;
		}

		private void agAddTimeReservationListMenuItem_Click(object sender, EventArgs e)
		{
			var dialog = new AgTimeReservationSettingDialog(new AgTimeReservation("無題", false, TimeSpan.FromMinutes(0), TimeSpan.FromMinutes(30), true), Ag);
			dialog.ShowDialog();

			if (dialog.DialogResult == DialogResult.OK)
			{
				try
				{
					Ag.ReservationList.Add(dialog.Reservation);
				}
				catch (InvalidOperationException ex)
				{
					throw new ApplicationException("予約の追加に失敗しました。", ex);
				}

				var item = new ListViewItem(new string[] { FormatTime(dialog.Reservation.StartTime), FormatTime(dialog.Reservation.EndTime), dialog.Reservation.Name });
				item.Tag = dialog.Reservation;
				agTimeReservationListView.Items.Add(item);
			}
		}

		private void agEditTimeReservationListMenuItem_Click(object sender, EventArgs e)
		{
			var listViewItem = agTimeReservationListView.SelectedItems[0];
			var reservation = (AgTimeReservation)listViewItem.Tag;

			var dialog = new AgTimeReservationSettingDialog(reservation, Ag);
			dialog.ShowDialog();

			if (dialog.DialogResult == DialogResult.OK)
			{
				var item = new ListViewItem(new string[] { FormatTime(reservation.StartTime), FormatTime(reservation.EndTime), reservation.Name });
				item.Tag = reservation;

				agTimeReservationListView.Items[agTimeReservationListView.Items.IndexOf(listViewItem)] = item;
			}
		}

		private void agDeleteTimeReservationListMenuItem_Click(object sender, EventArgs e)
		{
			var listViewItem = agTimeReservationListView.SelectedItems[0];
			var reservation = (AgTimeReservation)listViewItem.Tag;

			if (reservation.NeedStartRecording)
				Ag.StopRecord(false);

			agTimeReservationListView.Items.Remove(listViewItem);
			Ag.ReservationList.Remove(reservation);
		}

		private void agTimeReservationListView_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
				return;

			agEditTimeReservationListMenuItem_Click(this, null);
		}

		#endregion eventHandlers
	}
}
