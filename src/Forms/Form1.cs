using Stacker.Models;
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Stacker.Models.AgManager.ReservationTransitionEventArgs;

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
				var listViewItem = new ListViewItem(new string[] { $"{FormatTime(program.StartTime)} - {FormatTime(program.EndTime)}", program.Title, program.Personality, program.HasVideo ? "有" : "無" });
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

			agProgramLabel.Text = Ag.NowProgram.Title;
			agPersonalityLabel.Text = Ag.NowProgram.Personality;

			Status("準備完了");
		}

		#region EventHandlers

		private async void Form1_Load(object sender, EventArgs e)
		{
			Status("初期化しています...");
			var asmInfo = Assembly.GetExecutingAssembly().GetName();
			Text = string.Format(Text, asmInfo.Name, asmInfo.Version.ToString(3));

			if (!File.Exists("rtmpdump.exe"))
			{
				// await DownloadAndExtractFileAsync("https://rtmpdump.mplayerhq.hu/download/rtmpdump-2.4-git-010913-windows.zip", "rtmpdump.exe");
				MessageBox.Show("rtmpdump.exeが見つかりません", "エラー");
			}

			if (!File.Exists("ffmpeg.exe"))
			{
				// await DownloadAndExtractFileAsync("https://ffmpeg.zeranoe.com/builds/win32/static/ffmpeg-latest-win32-static.zip", "ffmpeg-latest-win32-static/bin/ffmpeg.exe", "ffmpeg.exe");
				MessageBox.Show("ffmpeg.exeが見つかりません", "エラー");
			}

			Ag = new AgManager();

			Ag.RecordStarted += (s, ev) =>
			{
				Status($"「{ev.Filename}」の録音が開始されました");
			};

			Ag.RecordStopped += (s, ev) =>
			{
				Status($"「{ev.Filename}」の録音が完了しました");
			};

			await UpdateProgramsAsync();
			UpdateForm();

			Ag.ProgramTransitioned += (s, ev) =>
			{
				agProgramLabel.Text = Ag.NowProgram?.Title ?? "未取得";
				agPersonalityLabel.Text = Ag.NowProgram?.Personality ?? "未取得";
			};

			Ag.ReservationTransitioned += (s, ev) =>
			{
				if (ev.Type == ReservationTransitionType.Begin)
				{
					Status($"時間予約「{ev.Reservation.Name}」が開始されました");
				}
				if (ev.Type == ReservationTransitionType.End)
				{
					Status($"時間予約「{ev.Reservation.Name}」が完了しました");
				}
			};

			Status("準備完了");
		}

		private void agStartRecordButton_Click(object sender, EventArgs e)
		{
			Ag.StartRecord($"realtime_{DateTime.Now.ToFileTime()}", true);
		}

		private void agStopRecordButton_Click(object sender, EventArgs e)
		{
			Task.Run(() => Ag.StopRecord(true));
		}

		private void agRecordSpecifiedTimeButton_Click(object sender, EventArgs e)
		{
			Task.Run(() => Ag.RecordSpecifiedTime((int)(60 * agLengthUpDown.Value), $"realtime_{DateTime.Now.ToFileTime()}", true));
		}

		private async void agUpdateProgramListMenuItem_Click(object sender, EventArgs e)
		{
			await UpdateProgramsAsync();
			UpdateForm();
		}

		private void agProgramListView_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
				return;

			var program = (AgProgram)agProgramListView.SelectedItems[0].Tag;
			var reservation = new AgTimeReservation(program.Title, program.StartTime, program.EndTime, true);

			var dialog = new AgTimeReservationSettingDialog(reservation, Ag);
			dialog.ShowDialog();

			if (dialog.DialogResult == DialogResult.OK)
			{
				var listViewItem = new ListViewItem(new string[] { FormatTime(reservation.StartTime), FormatTime(reservation.EndTime), reservation.Name });
				listViewItem.Tag = reservation;
				agTimeReservationListView.Items.Add(listViewItem);
			}
		}

		private void versionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var asmInfo = Assembly.GetExecutingAssembly().GetName();
			MessageBox.Show($"ver.{asmInfo.Version.ToString(3)}", $"{asmInfo.Name}のバージョン情報");
		}

		private void updateDisplayMenuItem_Click(object sender, EventArgs e)
		{
			UpdateForm();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start(".\\library\\ag");
		}
		#endregion eventHandlers
	}
}
