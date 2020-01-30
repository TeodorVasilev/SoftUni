namespace Pascal_Triangle
{
	using System;

	public class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			for (int row = 0; row < n; row++)
			{
				int num = 1;
				for (int col = 0; col <= row; col++)
				{
					Console.Write(num + " ");
					num = num * (row - col) / (col + 1);
				}

				Console.WriteLine();
			}
		}
	}
}
