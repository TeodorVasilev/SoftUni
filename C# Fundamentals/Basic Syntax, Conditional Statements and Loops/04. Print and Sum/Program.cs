﻿using System;

namespace _04._Print_and_Sum
{
	class Program
	{
		static void Main(string[] args)
		{
			int start = int.Parse(Console.ReadLine());
			int end = int.Parse(Console.ReadLine());

			int sum = 0;

			for (int i = start; i <= end; i++)
			{
				sum += i;
				Console.Write(i + " ");
			}

			Console.WriteLine();
			Console.WriteLine($"Sum: {sum}");
		}
	}
}
