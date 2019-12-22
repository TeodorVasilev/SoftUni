using System;
using System.Collections.Generic;
using System.Linq;
namespace _02SetsofElements
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

			var firstSetSize = input[0];
			var secondSetSize = input[1];

			var firstSet = new HashSet<int>();
			var secondSet = new HashSet<int>();

			for (int i = 0; i < firstSetSize; i++)
			{
				int number = int.Parse(Console.ReadLine());

				firstSet.Add(number);
			}
			
			for (int i = 0; i < secondSetSize; i++)
			{
				int number = int.Parse(Console.ReadLine());

				secondSet.Add(number);
			}

			Console.WriteLine(string.Join(" ", firstSet.Intersect(secondSet)));
		}
	}
}
