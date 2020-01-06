using System;

namespace ImplementLinkedList
{
	public class MyLinkedList
	{
		private MyNode head;// { get; private set; }
		private MyNode tail;// { get; private set; }

		public int Count { get; private set; }

		public object Head
		{
			get
			{
				this.ValidateIfListIsEmpty();

				return this.head.Value;
			}
		}

		public object Tail
		{
			get
			{
				this.ValidateIfListIsEmpty();

				return this.tail.Value;
			}
		}

		public void AddHead(object value)
		{
			var newNode = new MyNode(value);

			if (this.Count == 0)
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

		public void AddTail(object value)
		{
			var newNode = new MyNode(value);

			if (this.Count == 0)
			{
				this.head = this.tail = newNode;
			}
			else
			{
				var oldTail = this.tail;
				oldTail.Next = newNode;
				newNode.Previous = oldTail;
				this.tail = newNode;
			}

			this.Count++;
		}

		public object RemoveHead()
		{
			this.ValidateIfListIsEmpty();

			var value = this.head.Value;

			if (this.head == this.tail)
			{
				this.head = null;
				this.tail = null;
			}
			else
			{
				var newHead = this.head.Next;
				newHead.Previous = null;
				this.head.Next = null;
				this.head = newHead;
			}

			this.Count--;

			return value;
		}

		public bool Contains(object value)
		{
			var currentNode = this.head;

			while (currentNode != null)
			{
				if(currentNode.Value.Equals(value))
				{
					return true;
				}

				currentNode = currentNode.Next;
			}

			return false;
		}

		public object RemoveTail()
		{
			this.ValidateIfListIsEmpty();

			var value = this.tail.Value;

			if (this.tail == this.head)
			{
				this.tail = null;
				this.head = null;
			}
			else
			{
				var newTail = this.tail.Previous;
				newTail.Next = null;
				this.tail.Previous = null;
				this.tail = newTail;
			}

			this.Count--;

			return value;
		}

		public void Remove(object value)
		{
			var currentNode = this.head;

			while (currentNode != null)
			{
				var nodeValue = currentNode.Value;

				if(nodeValue.Equals(value))
				{
					this.Count--;

					var prevNode = currentNode.Previous;
					var nextNode = currentNode.Next;

					if(prevNode != null)
					{
						prevNode.Next = nextNode;
					}

					if(nextNode != null)
					{
						nextNode.Previous = prevNode;
					}

					if(this.head == currentNode)
					{
						this.head = nextNode;
					}

					if(this.tail == currentNode)
					{
						this.tail = prevNode;
					}
				}

				currentNode = currentNode.Next;
			}
		}

		public void Clear()
		{
			this.head = null;
			this.tail = null;
			this.Count = 0;
		}

		public void ForEach(Action<object> action, bool reverse = false)
		{
			var currentNode = reverse ? this.tail : this.head;

			while (currentNode != null)
			{
				action(currentNode.Value);
				currentNode = reverse ? currentNode.Previous : currentNode.Next;
			}
		}

		public object[] ToArray()
		{
			var arr = new object[this.Count];

			var currentNode = this.head;

			var index = 0;

			while (currentNode != null)
			{
				arr[index] = currentNode.Value;
				index++;
				currentNode = currentNode.Next;
			}

			return arr;
		}

		private void ValidateIfListIsEmpty()
		{
			if (this.Count == 0)
			{
				throw new InvalidOperationException("MyLinkedList is empty");
			}
		}
	}
}
