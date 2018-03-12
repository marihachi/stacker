using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Stacker.Utilities
{
	public static class ConsoleExecuter
	{
		internal const int CTRL_C_EVENT = 0;

		[DllImport("kernel32.dll")]
		internal static extern bool GenerateConsoleCtrlEvent(uint dwCtrlEvent, uint dwProcessGroupId);

		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern bool AttachConsole(uint dwProcessId);

		[DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
		internal static extern bool FreeConsole();

		[DllImport("kernel32.dll")]
		static extern bool SetConsoleCtrlHandler(ConsoleCtrlDelegate handlerRoutine, bool add);

		delegate bool ConsoleCtrlDelegate(uint CtrlType);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="filename"></param>
		/// <param name="arguments"></param>
		/// <param name="TimeoutMillisec"></param>
		public static void ExecuteOnConsole(string command, int TimeoutMillisec = 0)
		{
			var p = new Process();
			p.StartInfo.FileName = "cmd.exe";
			p.StartInfo.Arguments = $"/C {command}";
			p.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
			p.Start();

			if (TimeoutMillisec == 0)
				p.WaitForExit();
			else
				p.WaitForExit(TimeoutMillisec);
		}

		/// <summary>
		/// コンソール上でプロセスを起動し、そのコンソールのプロセスを返します
		/// </summary>
		/// <param name="filename"></param>
		/// <param name="arguments"></param>
		/// <param name="TimeoutMillisec"></param>
		/// <returns>pid</returns>
		public static Process StartOnConsole(string command, int TimeoutMillisec = 0)
		{
			var p = new Process();
			p.StartInfo.FileName = "cmd.exe";
			p.StartInfo.Arguments = $"/C {command}";
			p.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
			p.Start();

			return p;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="consoleProcess"></param>
		public static void StopConsole(Process consoleProcess)
		{
			if (!AttachConsole((uint)consoleProcess.Id))
				return;

			SetConsoleCtrlHandler(null, true);

			try
			{
				if (!GenerateConsoleCtrlEvent(CTRL_C_EVENT, 0))
					return;

				consoleProcess.WaitForExit();
			}
			finally
			{
				FreeConsole();
				SetConsoleCtrlHandler(null, false);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="filename"></param>
		/// <param name="arguments"></param>
		/// <param name="TimeoutMillisec"></param>
		public static void ExecuteDirect(string filename, string arguments, int TimeoutMillisec = 0)
		{
			var p = new Process();
			p.StartInfo.FileName = filename;
			p.StartInfo.Arguments = arguments;
			p.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
			p.Start();

			if (TimeoutMillisec == 0)
				p.WaitForExit();
			else
				p.WaitForExit(TimeoutMillisec);
		}
	}
}
