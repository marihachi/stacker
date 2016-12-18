using System;

namespace Stacker.Models.EventArgses
{
	public class RecordEventArgs : EventArgs
	{
		public RecordEventArgs(bool isRealtimeRecord, string filename)
		{
			IsRealtimeRecord = IsRealtimeRecord;
			Filename = filename;
		}

		public bool IsRealtimeRecord { get; set; }

		public string Filename { get; set; }
	}
}
