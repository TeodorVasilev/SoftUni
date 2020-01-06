using System;
using System.Collections.Generic;

namespace ImplementStack
{
	public class MyStack<T>
	{
		private T[] values;

		private int count;

		public MyStack()
			: this(16)
		{
		}

		public MyStack(int initialCapacity)
		{
			this.count = 0;
			this.values = new T[initialCapacity];
		}

		public int Count
		{
			get
			{
				return this.count;
			}
		}

		public void Push(T value)
		{
			if(this.count == this.values.Length)
			{
				var nextValues = new T[this.values.Length * 2];
				for (int i = 0; i < this.values.Length; i++)
				{
					nextValues[i] = this.values[i];
				}

				this.values = nextValues;
			}

			this.values[this.count] = value;
			this.count++;
		}

		public object Pop()
		{
			if(this.count == 0)
			{
				throw new InvalidOperationException("MyStack is empty.");
			}

			var lastIndex = this.count - 1;
			var last = this.values[lastIndex];
			this.count--;
			return last;
		}

		public void ForEach(Action<object> action)
		{
			for (int i = 0; i < this.count; i++)
			{
				action(this.values[i]);
			}
		}
	}
}
