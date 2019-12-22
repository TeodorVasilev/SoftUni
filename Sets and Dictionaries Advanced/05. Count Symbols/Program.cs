using System;
using System.Collections.Generic;

namespace _05.Count_Symbols
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();

			var symbolCount = new SortedDictionary<char, int>();

			for (int i = 0; i < input.Length; i++)
			{
				var symbol = input[i];

				if(symbolCount.ContainsKey(symbol))
				{
					symbolCount[symbol]++;
				}
				else
				{
					symbolCount[symbol] = 1;
				}
			}

			foreach (var kvp in symbolCount)
			{
				Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
			}
		}
	}
}
