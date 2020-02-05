namespace NxN_Matrix
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			DrawMatrix(n);
		}

		static void DrawMatrix(int n)
		{
			for (int row = 0; row < n; row++)
			{
				for (int col = 0; col < n; col++)
				{
					Console.Write(n + " ");
				}

				Console.WriteLine();
			}
		}
	}
}
