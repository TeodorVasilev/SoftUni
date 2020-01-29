namespace Array_Rotation
{
	using System;
    using System.Linq;

    public class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				int firstElement = numbers[0];

				for (int k = 0; k < numbers.Length -1; k++)
				{
					numbers[k] = numbers[k + 1];
				}

				numbers[numbers.Length - 1] = firstElement;
			}

			Console.WriteLine(string.Join(" ", numbers));
		}
	}
}
