namespace Printing_Triangle
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			PrintTop(n);
			PrintBot(n);
		}
		
		static void PrintTop(int n)
		{
			for (int row = 1; row <= n; row++)
			{
				for (int col = 1; col <= row; col++)
				{
					Console.Write(col + " ");
				}
				Console.WriteLine();
			}
		}

		static void PrintBot(int n)
		{
			for (int row = n - 1; row >= 0; row--)
			{
				for (int col = 1; col <= row; col++)
				{
					Console.Write(col + " ");
				}
				Console.WriteLine();
			}
		}
	}
}
