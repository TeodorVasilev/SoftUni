namespace Middle_Characters
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			int index = input.Length / 2;

			if (input.Length % 2 == 0)
			{
				Console.WriteLine(input.Substring(index-1, 2));
			}
			else
			{
				Console.WriteLine(input.Substring(index, 1));
			}
		}
	}
}
