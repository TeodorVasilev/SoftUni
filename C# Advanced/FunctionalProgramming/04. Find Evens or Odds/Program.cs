using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Find_Evens_or_Odds
{
	class Program
	{
		static void Main(string[] args)
		{
			Predicate<int> even = n => n % 2 == 0;
			Predicate<int> odd = n => n % 2 != 0;

			int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();
			Array.Sort(range);

			int numbersCount = range[1] - range[0] + 1;

			List<int> numbers = Enumerable.Range(range[0], numbersCount).ToList();

			string condition = Console.ReadLine();

			if(condition.Equals("even"))
			{
				numbers = numbers.FindAll(even);
			}
			else if(condition.Equals("odd"))
			{
				numbers = numbers.FindAll(odd);
			}

			Console.WriteLine(string.Join(" ", numbers));
		}
	}
}
