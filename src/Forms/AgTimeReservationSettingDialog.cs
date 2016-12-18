using Stacker.Models;
using System;
using System.Windows.Forms;

namespace Stacker.Forms
{
	public partial class AgTimeReservationSettingDialog : Form
	{
		public AgTimeReservationSettingDialog(AgTimeReservation reservation, AgManager ag)
		{
			InitializeComponent();
			Ag = ag;
			Reservation = reservation;
		}

		private AgManager Ag { get; set; }
		public AgTimeReservation Reservation { get; set; }

		private void AgTimeReservationSettingDialog_Load(object sender, EventArgs e)
		{
			textBox1.Text = Reservation.Name;
			dateTimePicker1.Value = new DateTime(1900, 1, 1, Reservation.StartTime.Hours, Reservation.StartTime.Minutes, 0);
			dateTimePicker2.Value = new DateTime(1900, 1, 1, Reservation.EndTime.Hours, Reservation.EndTime.Minutes, 0);
			comboBox1.SelectedIndex = Reservation.StartTime.Days;
			comboBox2.SelectedIndex = Reservation.EndTime.Days;
			checkBox1.Checked = false; // Reservation.IsRecordVideo
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Reservation.Name = textBox1.Text;
			Reservation.StartTime = new TimeSpan(dateTimePicker1.Value.Hour, dateTimePicker1.Value.Minute, 0).Add(TimeSpan.FromDays(comboBox1.SelectedIndex));
			Reservation.EndTime = new TimeSpan(dateTimePicker2.Value.Hour, dateTimePicker2.Value.Minute, 0).Add(TimeSpan.FromDays(comboBox2.SelectedIndex));
			// Reservation.IsRecordVideo = checkBox1.Checked;

			try
			{
				Ag.ReservationList.Add(Reservation);

				DialogResult = DialogResult.OK;
				Close();
			}
			catch (InvalidOperationException)
			{
				MessageBox.Show("他の予約の時間と重複しています。", "予約失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
