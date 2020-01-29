namespace Reverse_Array_of_Strings
{
	using System;

	public class Program
	{
		static void Main(string[] args)
		{
			string[] elements = Console.ReadLine().Split();

			Array.Reverse(elements);

			Console.WriteLine(string.Join(" ", elements));
		}
	}
}
