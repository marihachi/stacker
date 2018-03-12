using System;
using System.Windows.Forms;

namespace Stacker.Forms
{
	public partial class AgRecordSpecifiedTimeSettingDialog : Form
	{
		public AgRecordSpecifiedTimeSettingDialog()
		{
			InitializeComponent();
		}

		public int Length { get; set; }

		private void AgRecordSpecifiedTimeSettingDialog_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Length = (int)agLengthUpDown.Value;
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
