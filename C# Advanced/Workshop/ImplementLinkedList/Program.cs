using System;

namespace ImplementLinkedList
{
	class Program
	{
		static void Main(string[] args)
		{
			var linkedList = new MyLinkedList();

			linkedList.AddHead(5);
			linkedList.AddHead(10);
			linkedList.AddHead(15);

			//15 <-> 10 <-> 5

			Console.WriteLine(linkedList.Count == 3);
		}
	}
}
