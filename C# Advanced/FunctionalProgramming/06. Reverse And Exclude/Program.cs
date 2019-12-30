using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Reverse_And_Exclude
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

			int n = int.Parse(Console.ReadLine());

			numbers.Reverse();

			Func<int, bool> Filter = x => x % n != 0;

			var remainingNumbers = numbers.Where(Filter).ToList();

			Console.WriteLine(string.Join(" ", remainingNumbers));
		}
	}
}
