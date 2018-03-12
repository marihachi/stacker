using System;
using System.Collections;
using System.Windows.Forms;

namespace Stacker.Utilities
{
	/// <summary>
	/// ListViewの項目の並び替えに使用するクラス
	/// </summary>
	public class ListViewItemComparer : IComparer
	{
		/// <summary>
		/// ListViewItemComparerクラスのコンストラクタ
		/// </summary>
		/// <param name="col">並び替える列の番号</param>
		/// <param name="ord">昇順か降順か</param>
		/// <param name="cmod">並び替えの方法</param>
		public ListViewItemComparer(
			int col, SortOrder ord, ComparerMode cmod)
		{
			_Column = col;
			OrderBy = ord;
			Mode = cmod;
		}

		public ListViewItemComparer()
		{
			_Column = 0;
			OrderBy = SortOrder.Ascending;
			Mode = ComparerMode.String;
		}

		/// <summary>
		/// 比較タイプ
		/// </summary>
		public enum ComparerMode
		{
			/// <summary>
			/// 文字列として比較
			/// </summary>
			String,

			/// <summary>
			/// 数値（Int32型）として比較
			/// </summary>
			Integer,

			/// <summary>
			/// 日時（DataTime型）として比較
			/// </summary>
			DateTime
		};

		/// <summary>
		/// 並び替えるListView列の番号
		/// </summary>
		public int Column
		{
			set
			{
				//現在と同じ列の時は、昇順降順を切り替える
				if (_Column == value)
				{
					if (OrderBy == SortOrder.Ascending)
					{
						OrderBy = SortOrder.Descending;
					}
					else if (OrderBy == SortOrder.Descending)
					{
						OrderBy = SortOrder.Ascending;
					}
				}
				_Column = value;
			}
			get
			{
				return _Column;
			}
		}
		private int _Column;

		/// <summary>
		/// 昇順か降順か
		/// </summary>
		public SortOrder OrderBy { get; set; }

		/// <summary>
		/// 並び替えの方法
		/// </summary>
		public ComparerMode Mode { get; set; }

		/// <summary>
		/// 列ごとの並び替えの方法
		/// </summary>
		public ComparerMode[] ColumnModes { get; set; }

		// xがyより小さいときはマイナスの数、大きいときはプラスの数、
		// 同じときは0を返す
		public int Compare(object x, object y)
		{
			if (OrderBy == SortOrder.None)
				return 0;

			int result = 0;
			// ListViewItemの取得
			var itemx = (ListViewItem)x;
			var itemy = (ListViewItem)y;

			// 並べ替えの方法を決定
			if (ColumnModes != null && ColumnModes.Length > _Column)
				Mode = ColumnModes[_Column];

			// モード別に比較
			if (Mode == ComparerMode.Integer)
				result = int.Parse(itemx.SubItems[_Column].Text).CompareTo(int.Parse(itemy.SubItems[_Column].Text));
			else if (Mode == ComparerMode.DateTime)
				result = DateTime.Compare(DateTime.Parse(itemx.SubItems[_Column].Text), DateTime.Parse(itemy.SubItems[_Column].Text));
			else if (Mode == ComparerMode.String)
				result = string.Compare(itemx.SubItems[_Column].Text, itemy.SubItems[_Column].Text);
			else
			{
			}

			// 降順の時は結果を逆にする
			if (OrderBy == SortOrder.Descending)
				result = -result;

			return result;
		}
	}
}
