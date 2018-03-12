using Codeplex.Data;
using Newtonsoft.Json;
using Stacker.Models.EventArgses;
using Stacker.Utilities;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace Stacker.Models.Ag
{
	/// <summary>
	/// 超！A＆G＋の配信をレコードする機能を提供します
	/// </summary>
	public class Recorder : IDisposable
	{
		public Recorder(string recorderName)
		{
			Name = recorderName;
		}

		#region Events

		public event EventHandler<EventArgs<string>> RecordStarted;

		public void OnRecordStarted() =>
			RecordStarted?.Invoke(this, new EventArgs<string>(Filename));

		public event EventHandler<EventArgs<string>> RecordStopped;

		public void OnRecordStopped() =>
			RecordStopped?.Invoke(this, new EventArgs<string>(Filename));

		#endregion Events

		#region Properties and getter methods

		private string Name { get; set; }

		private Process ConsoleProcess { get; set; }

		private string Filename { get; set; }

		private bool IsVideo { get; set; }

		#endregion Properties and getter methods

		#region Action methods

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

			var doc = new XmlDocument();
			doc.LoadXml(new HttpClient().GetAsync("http://www.uniqueradio.jp/agplayerf/getfmsListHD.php").Result.Content.ReadAsStringAsync().Result);
			var jStr = JsonConvert.SerializeXmlNode(doc);
			var j = DynamicJson.Parse(jStr);

			string server = null;
			string app = null;
			string playpath = null;

			foreach (var serverinfo in j.ag.serverlist.serverinfo)
			{
				if (string.IsNullOrEmpty(serverinfo.cryptography))
				{
					server = serverinfo.server;
					app = serverinfo.app;
					playpath = serverinfo.stream;
					break;
				}
			}

			if (server == null)
				throw new ApplicationException("A&Gのストリーミングサーバー情報の取得に失敗しました。");

			// Console.WriteLine($"rtmpdump -v -r \"{server}\" --app \"{app}\" --playpath {playpath} | ffmpeg -y -i pipe:0 --acodec copy ./library/ag/temp_{Name}.{(isVideo ? "mp4" : "mp3")}");
			var bitrate = "32k";
			
			var process = ConsoleExecuter.StartOnConsole(
				$"rtmpdump -v -r \"{server}\" --app \"{app}\" --playpath {playpath} | ffmpeg -y -i pipe:0 -ab {bitrate} ./library/ag/temp_{Name}.{(isVideo ? "mp4" : "mp3")}");

			Filename = filename;
			ConsoleProcess = process;
			IsVideo = isVideo;

			OnRecordStarted();
		}

		public void StopRecord()
		{
			if (ConsoleProcess == null)
				return;

			ConsoleExecuter.StopConsole(ConsoleProcess);

			try
			{
				File.Move($"./library/ag/temp_{Name}.{(IsVideo ? "mp4" : "mp3")}", $"./library/ag/{Regex.Replace(Filename, @"[\/:*?""<>|]+", i => " ")}.{(IsVideo ? "mp4" : "mp3")}");
			}
			catch (IOException ex)
			{
				throw new ApplicationException("ファイル名のリネームに失敗しました。", ex);
			}

			OnRecordStopped();
			ConsoleProcess = null;
		}

		public void Dispose()
		{
			if (ConsoleProcess != null)
				StopRecord();
		}

		#endregion Action methods
	}
}
