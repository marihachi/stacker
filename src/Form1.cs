using Stacker.Model;
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stacker
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
			return $"{Culture.DateTimeFormat.GetAbbreviatedDayName((DayOfWeek)time.Days)} {time.Hours:00}:{time.Minutes:00}";
		}

		private void UpdateForm()
		{
			Status("画面を更新しています...");

			agProgramListView.Items.Clear();
			foreach (var program in Ag.ProgramList)
			{
				var listViewItem = new ListViewItem(new string[] { FormatTime(program.Time), program.Title, program.Personality, program.HasVideo ? "有" : "無" });
				listViewItem.Tag = program;
				agProgramListView.Items.Add(listViewItem);
			}

			agReservationListView.Items.Clear();
			foreach (var reservation in Ag.ReservationList)
			{
				var listViewItem = new ListViewItem(new string[] { FormatTime(reservation.StartTime), FormatTime(reservation.EndTime), reservation.Name });
				listViewItem.Tag = reservation;
				agReservationListView.Items.Add(listViewItem);
			}

			agProgramLabel.Text = Ag.NowProgram.Title;
			agPersonalityLabel.Text = Ag.NowProgram.Personality;

			Status("準備完了");
		}

		public void AddReservation(AgReservation reservation)
		{
			try
			{
				Ag.ReservationList.Add(reservation);
				
				var listViewItem = new ListViewItem(new string[] { FormatTime(reservation.StartTime), FormatTime(reservation.EndTime), reservation.Name });
				listViewItem.Tag = reservation;
				agReservationListView.Items.Add(listViewItem);

				Debug.WriteLine($"{agProgramListView.SelectedIndices[0]}: {Culture.DateTimeFormat.GetAbbreviatedDayName((DayOfWeek)reservation.StartTime.Days)}{reservation.StartTime.ToString(@"hh\:mm")} - {Culture.DateTimeFormat.GetAbbreviatedDayName((DayOfWeek)reservation.EndTime.Days)}{reservation.EndTime.ToString(@"hh\:mm")} ({reservation.Name}) を予約しました");
			}
			catch (InvalidOperationException)
			{
				MessageBox.Show("他の予約の時間と重複しています。", "予約失敗");
			}
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

			Ag.RecordStarted += (s, ev) => { Status($"「{ev.Filename}」の録音が開始されました"); };
			Ag.RecordStopped += (s, ev) => { Status($"「{ev.Filename}」の録音が完了しました"); };

			await UpdateProgramsAsync();
			UpdateForm();

			Ag.ProgramTransitioned += (s, ev) => {
				agProgramLabel.Text = Ag.NowProgram.Title;
				agPersonalityLabel.Text = Ag.NowProgram.Personality;
			};

			Ag.ReservationTransitioned += (s, ev) => {
				if (ev.Type == AgManager.ReservationTransitionEventArgs.ReservationTransitionType.Begin)
				{
					Ag.StartRecord($"{DateTime.Now.Year:0000}{DateTime.Now.Month:00}{DateTime.Now.Day:00}_{ev.Reservation.Name}", false);
				}
				else
				{
					Ag.StopRecord(false);
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
			if (e.Button == MouseButtons.Left)
			{
				var program = (AgProgram)agProgramListView.SelectedItems[0].Tag;

				var reservation = new AgReservation(program.Title, program.Time, program.Time + program.Length, true);
				AddReservation(reservation);
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

		#endregion eventHandlers
	}
}
