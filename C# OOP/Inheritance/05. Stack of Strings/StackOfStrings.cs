namespace _05._Stack_of_Strings
{
	using System.Collections.Generic;

	public class StackOfStrings : Stack<string>
	{
		public bool IsEmpty()
		{
			return this.Count == 0;
		}

		public void AddRange(params string[] data)
		{
			foreach (var item in data)
			{
				this.Push(item);
			}
		}
	}
}
