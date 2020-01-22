namespace CollectionHierarchy
{
	public class Node
	{
		public Node(object value)
		{
			this.Value = value;
		}

		public object Value { get; private set; }

		public Node Next { get; set; }

		public Node Previous { get; set; }
	}
}
