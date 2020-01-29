namespace Equal_Arrays
{
	using System;
    using System.Linq;

    public class Program
	{
		static void Main(string[] args)
		{
			int[] firstNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int[] secondNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

			for (int i = 0; i < firstNumbers.Length; i++)
			{
				if(firstNumbers[i] != secondNumbers[i])
				{
					Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
					return;
				}
			}

			Console.WriteLine($"Arrays are identical. Sum: {firstNumbers.Sum()}");
		}
	}
}
