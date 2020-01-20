namespace _11._Sort_Numbers
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	class Program
	{
		static void Main(string[] args)
		{
			var numbers = new List<int>(); 

			for (int i = 0; i < 3; i++)
			{
				var number = int.Parse(Console.ReadLine());

				numbers.Add(number);
			}

			var sorted = numbers.OrderByDescending(x => x).ToList();

			sorted.ForEach(Console.WriteLine);
		}
	}
}
