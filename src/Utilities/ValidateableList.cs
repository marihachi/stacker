using System;
using System.Collections;
using System.Collections.Generic;

namespace Stacker.Utilities
{
	public class ValidateableList<T> : IList<T>
	{
		public ValidateableList(Func<T, bool> addValidater = null)
		{
			AddValidater = addValidater ?? new Func<T, bool>((i) => true);
		}

		public T this[int index]
		{
			get
			{
				return InternalList[index];
			}
			set
			{
				var result = AddValidater(value);

				if (!result)
					throw new InvalidOperationException();

				InternalList[index] = value;
			}
		}

		public Func<T, bool> AddValidater { get; private set; }

		public int Count => InternalList.Count;

		public bool IsReadOnly => false;

		private List<T> InternalList { get; set; } = new List<T>();

		public void Add(T item)
		{
			if (!AddValidater(item))
				throw new InvalidOperationException();

			InternalList.Add(item);
		}

		public void AddRange(IEnumerable<T> collection)
		{
			foreach(var item in collection)
				if (!AddValidater(item))
					throw new InvalidOperationException();

			InternalList.AddRange(collection);
		}


		public void Clear()
		{
			InternalList.Clear();
		}

		public bool Contains(T item)
		{
			return InternalList.Contains(item);
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
			InternalList.CopyTo(array, arrayIndex);
		}

		public T Find(Predicate<T> match)
		{
			return InternalList.Find(match);
		}

		public IEnumerator<T> GetEnumerator()
		{
			return InternalList.GetEnumerator();
		}

		public int IndexOf(T item)
		{
			return InternalList.IndexOf(item);
		}

		public void Insert(int index, T item)
		{
			var result = AddValidater(item);

			if (!result)
				throw new InvalidOperationException();

			InternalList.Insert(index, item);
		}

		public bool Remove(T item)
		{
			return InternalList.Remove(item);
		}

		public void RemoveAt(int index)
		{
			InternalList.RemoveAt(index);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return InternalList.GetEnumerator();
		}
	}
}
