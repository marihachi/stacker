using System;

namespace Stacker.Models.EventArgses
{
	public class EventArgs<T> : EventArgs
	{
		public EventArgs(T data)
		{
			Data = data;
		}

		public T Data { get; set; }
	}
}
