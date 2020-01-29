namespace Zig_Zag_Arrays
{
	using System;
    using System.Linq;

    public class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int[] firstArr = new int[n];
			int[] secondArr = new int[n];

			for (int i = 0; i < n; i++)
			{
				int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

				if(i % 2 == 0)
				{
					firstArr[i] = numbers[0];
					secondArr[i] = numbers[1];
				}
				else
				{
					firstArr[i] = numbers[1];
					secondArr[i] = numbers[0];
				}
			}

			Console.WriteLine(string.Join(" ", firstArr));
			Console.WriteLine(string.Join(" ", secondArr));
		}
	}
}
