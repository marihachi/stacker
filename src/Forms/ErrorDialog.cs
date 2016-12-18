using System;
using System.Windows.Forms;

namespace Stacker.Forms
{
	public partial class ErrorDialog : Form
	{
		public ErrorDialog(Exception ex)
		{
			InitializeComponent();
			Ex = ex;
		}

		private Exception Ex { get; set; }

		private void ErrorDialog_Load(object sender, EventArgs e)
		{
			exceptionNameLabel.Text = string.Format(exceptionNameLabel.Text, Ex.GetType().ToString());
			messageLabel.Text = string.Format(messageLabel.Text, Ex.Message);
			textBox1.Text = Ex.StackTrace;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
