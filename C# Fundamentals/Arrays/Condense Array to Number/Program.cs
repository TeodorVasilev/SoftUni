﻿namespace Condense_Array_to_Number
{
	using System;
    using System.Linq;

    public class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

			while (numbers.Length > 1)
			{
				int[] condensed = new int[numbers.Length - 1];

				for (int i = 0; i < condensed.Length; i++)
				{
					condensed[i] = numbers[i] + numbers[i + 1];
				}

				numbers = condensed;
			}

			Console.WriteLine(numbers[0]);
		}
	}
}
