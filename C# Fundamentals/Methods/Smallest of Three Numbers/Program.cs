namespace Smallest_of_Three_Numbers
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int c = int.Parse(Console.ReadLine());

			Console.WriteLine(Math.Min(Math.Min(a, b), c));
		}
	}
}
