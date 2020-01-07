using System;

namespace _02._Generic_Array_Creator
{
	public class StartUp
	{
		static void Main(string[] args)
		{
			string[] strings = ArrayCreator.Create(5, "Pesho");

			int[] integers = ArrayCreator.Create(10, 20);

			foreach (var item in strings)
			{
				Console.WriteLine(item == "Pesho");
			}
		}
	}
}
