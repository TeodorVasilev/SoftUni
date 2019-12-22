using System;
using System.Collections.Generic;

namespace _04.Even_Times
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());

			var numbers = new Dictionary<int, int>();

			for (int i = 0; i < n; i++)
			{
				var number = int.Parse(Console.ReadLine());

				if(numbers.ContainsKey(number))
				{
					numbers[number]++;
				}
				else
				{
					numbers[number] = 1;
				}
			}

			foreach (var kvp in numbers)
			{
				if(kvp.Value % 2 == 0)
				{
					Console.WriteLine(kvp.Key);
				}
			}
		}
	}
}
