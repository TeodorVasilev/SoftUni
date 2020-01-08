using System;
using System.Linq;

namespace _01.ArraySumRecursion
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

			var result = FindSum(numbers, 0);

			Console.WriteLine(result);
		}

		public static int FindSum(int[] numbers, int index)
		{
			if(index == numbers.Length)
			{
				return 0;
			}

			var result = numbers[index] + FindSum(numbers, ++index);
			return result;
		}
	}
}
