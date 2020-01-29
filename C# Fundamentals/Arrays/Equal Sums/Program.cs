namespace Equal_Sums
{
	using System;
    using System.Linq;

    public class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

			for (int i = 0; i < numbers.Length; i++)
			{
				int leftSum = 0;
				int rightSum = 0;

				int element = numbers[i];

				for (int l = i - 1; l >= 0; l--)
				{
					leftSum += numbers[l];
				}

				for (int r = i + 1; r < numbers.Length; r++)
				{
					rightSum += numbers[r];
				}

				if(leftSum == rightSum)
				{
					Console.WriteLine(i);
					return;
				}
			}

			Console.WriteLine("no");
		}
	}
}
