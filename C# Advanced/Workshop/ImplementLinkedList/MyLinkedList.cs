using System;

namespace ImplementLinkedList
{
	public class MyLinkedList
	{
		private MyNode head;
		private MyNode tail;

		public int Count { get; private set; }

		public void AddHead(object value)
		{
			var newNode = new MyNode(value);

			if(this.Count == 0)
			{
				this.head = this.tail = newNode;
			}
			else
			{
				var oldHead = this.head;
				oldHead.Previous = newNode;
				newNode.Next = oldHead;
				this.head = newNode;
			}

			this.Count++;
		}
	}
}
