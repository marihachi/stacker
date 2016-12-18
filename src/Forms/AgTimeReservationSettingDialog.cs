using Stacker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stacker.Forms
{
	public partial class AgTimeReservationSettingDialog : Form
	{
		public AgTimeReservationSettingDialog(AgTimeReservation reservation)
		{
			InitializeComponent();
			Reservation = (AgTimeReservation)reservation.Clone();
		}

		public AgTimeReservation Reservation { get; set; }

		private void button1_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}

		private void AgTimeReservationSettingDialog_Load(object sender, EventArgs e)
		{
			textBox1.Text = Reservation.Name;
			dateTimePicker1.Value = new DateTime(1900, 1, 1, Reservation.StartTime.Hours, Reservation.StartTime.Minutes, 0);
			dateTimePicker2.Value = new DateTime(1900, 1, 1, Reservation.EndTime.Hours, Reservation.EndTime.Minutes, 0);
			comboBox1.SelectedIndex = Reservation.StartTime.Days;
			comboBox2.SelectedIndex = Reservation.EndTime.Days;
			checkBox1.Checked = false;
		}
	}
}
