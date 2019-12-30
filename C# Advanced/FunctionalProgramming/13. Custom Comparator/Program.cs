using System;
using System.Linq;

namespace _13.Custom_Comparator
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

			Func<int, int, int> sortFunc = (a, b) => a.CompareTo(b);

			Action<int[],int[]> print = (x,y) => Console.Write($"{string.Join(" ", x)} {string.Join(" ",y)}");

			int[] evenNumbers = numbers.Where(x => x % 2 == 0).ToArray();
			int[] oddNumbers = numbers.Where(x => x % 2 != 0).ToArray();

			Array.Sort(evenNumbers, new Comparison<int>(sortFunc));
			Array.Sort(oddNumbers, new Comparison<int>(sortFunc));
			
			print(evenNumbers, oddNumbers);
		}
	}
}
