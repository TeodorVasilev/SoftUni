namespace Repeat_String
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			int n = int.Parse(Console.ReadLine());
			RepeatString(input, n);
		}

		static void RepeatString(string input, int n)
		{
			for (int i = 0; i < n; i++)
			{
				Console.Write(input);
			}
			Console.WriteLine();
		}
	}
}
