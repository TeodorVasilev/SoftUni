using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Applied_Arithmetics
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

			string command = Console.ReadLine();

			Action<string> manipulateList = operation =>
			{
				switch (operation)
				{
					case "add":
						numbers = numbers.Select(n => n + 1).ToList();
						break;
					case "multiply":
						numbers = numbers.Select(n => n * 2).ToList();
						break;
					case "subtract":
						numbers = numbers.Select(n => n - 1).ToList();
						break;
					case "print":
						Console.WriteLine(string.Join(" ", numbers));
						break;
				}
			};

			while (command != "end")
			{
				manipulateList(command);

				command = Console.ReadLine();
			}
		}
	}
}
