using System;

namespace P01._Rhombus_of_Stars
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			
			PrintTop(n);
			PrintBot(n);
		}

		static void PrintBot(int n)
		{
			int stars = n - 1;
			int spaces = 1;

			for (int row = n - 1; row > 0; row--)
			{
				for (int col = 0; col < spaces; col++)
				{
					Console.Write(' ');
				}
				Console.Write('*');
				for (int col = 1; col < stars; col++)
				{
					Console.Write(" *");
				}

				Console.WriteLine();

				stars--;
				spaces++;
			}
		}

		static void PrintTop(int n)
		{
			int stars = 1;
			int spaces = n - 1;

			for (int row = 0; row < n; row++)
			{
				for (int col = 0; col < spaces; col++)
				{
					Console.Write(' ');
				}
				Console.Write('*');
				for (int col = 1; col < stars; col++)
				{
					Console.Write(" *");
				}

				Console.WriteLine();

				stars++;
				spaces--;
			}
		}
	}
}
