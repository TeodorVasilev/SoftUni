namespace _03.Count_Real_Numbers
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	class Program
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

			var sorted = new SortedDictionary<double, int>();

			foreach (var number in numbers)
			{
				if(!sorted.ContainsKey(number))
				{
					sorted[number] = 1;
				}
				else
				{
					sorted[number]++;
				}
			}

			foreach (var kvp in sorted)
			{
				Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
			}
		}
	}
}
