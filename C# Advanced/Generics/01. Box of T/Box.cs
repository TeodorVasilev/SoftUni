using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Box_of_T
{
	public class Box<T>
	{
		private T[] elements;

		private int count;

		public Box()
			: this(16)
		{

		}

		public Box(int initialCapacity)
		{
			this.count = 0;
			this.elements = new T[initialCapacity];
		}

		public int Count
		{
			get
			{
				return this.count;
			}
		}

		public void Add(T element)
		{
			if (this.count == this.elements.Length)
			{
				var nextValues = new T[this.elements.Length * 2];
				for (int i = 0; i < this.elements.Length; i++)
				{
					nextValues[i] = this.elements[i];
				}

				this.elements = nextValues;
			}

			this.elements[this.count] = element;
			this.count++;
		}

		public T Remove()
		{

			if (this.count == 0)
			{
				throw new InvalidOperationException("Box is empty.");
			}

			var lastIndex = this.count - 1;
			var topMostElement = this.elements[lastIndex];
			this.count--;
			return topMostElement;
		}
	}
}
