using Stacker.Models.EventArgses;
using Stacker.Utilities;
using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Stacker.Models
{
	/// <summary>
	/// 超！A＆G＋の配信をレコードする機能を提供します
	/// </summary>
	public class AgRecorder : IDisposable
	{
		public AgRecorder(string recorderName)
		{
			Name = recorderName;
		}

		public event EventHandler<EventArgs<string>> RecordStarted;

		public void OnRecordStarted() =>
			RecordStarted?.Invoke(this, new EventArgs<string>(Filename));

		public event EventHandler<EventArgs<string>> RecordStopped;

		public void OnRecordStopped() =>
			RecordStopped?.Invoke(this, new EventArgs<string>(Filename));

		private string Name { get; set; }
		private Process ConsoleProcess { get; set; }
		private string Filename { get; set; }
		private bool IsVideo { get; set; }

		private void CreateOutputDirectory()
		{
			var dir = $"./library/ag/";
			if (!Directory.Exists(dir))
				Directory.CreateDirectory(dir);
		}

		public void RecordSpecifiedTime(int specifiedTimeSec, string filename, bool isVideo)
		{
			StartRecord(filename, isVideo);
			Task.Delay(TimeSpan.FromSeconds(specifiedTimeSec)).Wait();
			StopRecord();
		}

		public void StartRecord(string filename, bool isVideo)
		{
			CreateOutputDirectory();

			var process = ConsoleExecuter.StartOnConsole(
				$"rtmpdump -v -r \"rtmpe://fms1.uniqueradio.jp/\" -a ?rtmp://fms-base2.mitene.ad.jp/agqr/ -y aandg22 | ffmpeg -y -i pipe:0 ./library/ag/temp_{Name}.{(isVideo ? "mp4" : "mp3")}");

			Filename = filename;
			ConsoleProcess = process;
			IsVideo = isVideo;

			OnRecordStarted();
		}

		public void StopRecord()
		{
			if (ConsoleProcess != null)
			{
				ConsoleExecuter.StopConsole(ConsoleProcess);
				File.Move($"./library/ag/temp_{Name}.{(IsVideo ? "mp4" : "mp3")}", $"./library/ag/{Regex.Replace(Filename, @"[\/:*?""<>|]+", i => " ")}.{(IsVideo ? "mp4" : "mp3")}");
				OnRecordStopped();
				ConsoleProcess = null;
			}
		}

		public void Dispose()
		{
			if (ConsoleProcess != null)
				StopRecord();
		}
	}
}
