using System;

namespace Stacker.Models.EventArgses
{
	/// <summary>
	/// 汎用のイベント引数を表します
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class EventArgs<T> : EventArgs
	{
		public EventArgs(T data)
		{
			Data = data;
		}

		/// <summary>
		/// このイベントに属するデータを取得または設定します
		/// </summary>
		public T Data { get; set; }
	}
}
