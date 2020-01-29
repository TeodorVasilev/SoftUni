namespace Magic_Sum
{
	using System;
    using System.Linq;

    public class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < numbers.Length; i++)
			{
				for (int k = i; k < numbers.Length - 1; k++)
				{
					if(numbers[i] + numbers[k + 1] == n)
					{
						Console.WriteLine($"{numbers[i]} {numbers[k + 1]}");
						break;
					}
				}
			}
		}
	}
}
