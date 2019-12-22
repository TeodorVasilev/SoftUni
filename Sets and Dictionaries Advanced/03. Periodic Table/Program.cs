using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Periodic_Table
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			var sortedElements = new SortedSet<string>();

			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split().ToArray();

				for (int k = 0; k < input.Length; k++)
				{
					sortedElements.Add(input[k]);
				}
			}

			Console.WriteLine(string.Join(" ", sortedElements));
		}
	}
}
