using Stacker.Forms;
using System;
using System.Windows.Forms;

namespace Stacker
{
	static class Program
	{
		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			var f = new Form1();

			AppDomain.CurrentDomain.UnhandledException += (s, e) =>
			{
				try
				{
					Error((Exception)e.ExceptionObject);
				}
				finally
				{
					Application.Exit();
				}
			};

			try
			{
				Application.Run(f);
			}
			catch (Exception ex)
			{
				Error(ex);
			}
			finally
			{
				f.Ag?.Dispose();
			}
		}

		static void Error(Exception ex)
		{
			var errorDialog = new ErrorDialog(ex);

			errorDialog.ShowDialog();
		}
	}
}
