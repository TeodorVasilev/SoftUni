namespace Sum_of_Chars
{
	using System;

	public class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int sum = 0;

			for (int i = 0; i < n; i++)
			{
				char letter = char.Parse(Console.ReadLine());

				sum += (int)letter;
			}

			Console.WriteLine($"The sum equals: {sum}");
		}
	}
}
