namespace _08._Triangle_of_Numbers
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			for (int row = 1; row <= n; row++)
			{
				for (int col = 1; col <= row; col++)
				{
					Console.Write(row + " ");
				}
				Console.WriteLine();
			}
		}
	}
}
