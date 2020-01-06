namespace ImplementLinkedList
{
	public class MyNode
	{
		public MyNode(object value)
		{
			this.Value = value;
		}

		public object Value { get; private set; }

		public MyNode Next { get; set; }

		public MyNode Previous { get; set; }
	}
}
