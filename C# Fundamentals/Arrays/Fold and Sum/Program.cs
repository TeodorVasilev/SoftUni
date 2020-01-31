namespace Fold_and_Sum
{
	using System;
    using System.Linq;

    public class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

			int k = numbers.Length / 4;

			int[] left = numbers.Take(k).Reverse().ToArray();
			int[] right = numbers.Reverse().Take(k).ToArray();

			int[] firstRow = left.Concat(right).ToArray();
			int[] secondRow = numbers.Skip(k).Take(k * 2).ToArray();

			int[] sum = firstRow.Select((x, index) => x + secondRow[index]).ToArray();

			Console.WriteLine(string.Join(" ", sum));
		}
	}
}
