using System;
using System.Windows.Forms;

namespace Stacker.Forms
{
	public partial class AgTimeReservationSettingDialog : Form
	{
		public AgTimeReservationSettingDialog(Models.Ag.TimeReservation reservation)
		{
			InitializeComponent();

			Reservation = reservation;
		}

		public Models.Ag.TimeReservation Reservation { get; set; }

		private void AgTimeReservationSettingDialog_Load(object sender, EventArgs e)
		{
			textBox1.Text = Reservation.Name;
			dateTimePicker1.Value = new DateTime(1900, 1, 1, Reservation.StartTime.Hours, Reservation.StartTime.Minutes, 0);
			dateTimePicker2.Value = new DateTime(1900, 1, 1, Reservation.EndTime.Hours, Reservation.EndTime.Minutes, 0);
			comboBox1.SelectedIndex = Reservation.StartTime.Days;
			comboBox2.SelectedIndex = Reservation.EndTime.Days;
			checkBox1.Checked = Reservation.IsRecordVideo;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var startTime = new TimeSpan(dateTimePicker1.Value.Hour, dateTimePicker1.Value.Minute, 0).Add(TimeSpan.FromDays(comboBox1.SelectedIndex));
			var endTime = new TimeSpan(dateTimePicker2.Value.Hour, dateTimePicker2.Value.Minute, 0).Add(TimeSpan.FromDays(comboBox2.SelectedIndex));

			if (endTime == startTime)
			{
				MessageBox.Show("開始/終了時間を同じ値にすることはできません", "エラー");
				return;
			}

			if (Reservation.Manager.Reserver.IsDuplicateTimeReservation(startTime, endTime, Reservation))
			{
				MessageBox.Show("他の予約と時間が重複しています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (Reservation.Manager.Reserver.IsDuplicateNameReservation(textBox1.Text, Reservation))
			{
				MessageBox.Show("他の予約と予約名が重複しています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Reservation.Name = textBox1.Text;
			Reservation.IsRecordVideo = checkBox1.Checked;
			Reservation.StartTime = startTime;
			Reservation.EndTime = endTime;

			DialogResult = DialogResult.OK;
			Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
