namespace CollectionHierarchy
{
	using System;

	public class AddRemoveCollection
	{
		private Node head;
		private Node tail;

		public int Count { get; private set; }

		public object Head
		{
			get
			{
				this.ValidateIfCollectionIsEmpty();

				return this.head.Value;
			}
		}

		public object Tail
		{
			get
			{
				this.ValidateIfCollectionIsEmpty();

				return this.tail.Value;
			}
		}

		public void Add(object value)
		{
			var newNode = new Node(value);

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

		public object Remove()
		{
			this.ValidateIfCollectionIsEmpty();

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

		private void ValidateIfCollectionIsEmpty()
		{
			if (this.Count == 0)
			{
				throw new InvalidOperationException("AddRemoveCollection is empty");
			}
		}
	}
}
