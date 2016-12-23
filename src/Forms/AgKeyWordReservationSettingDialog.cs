using Stacker.Models;
using Stacker.Models.Enums;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Stacker.Forms
{
	public partial class AgKeywordReservationSettingDialog : Form
	{
		public AgKeywordReservationSettingDialog(AgKeywordReservation reservation)
		{
			InitializeComponent();

			Reservation = reservation;
		}

		public AgKeywordReservation Reservation { get; set; }

		private void AgKeywordReservationSettingDialog_Load(object sender, EventArgs e)
		{
			textBox1.Text = Reservation.Keyword;
			comboBox1.SelectedIndex = (int)Reservation.ConditionType;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (Regex.IsMatch(textBox1.Text, "^[ 　\t]*$"))
			{
				MessageBox.Show("空のキーワードを設定することはできません", "エラー");
				return;
			}

			Reservation.Keyword = textBox1.Text;
			Reservation.ConditionType = (AgKeywordReservationConditionType)comboBox1.SelectedIndex;

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
