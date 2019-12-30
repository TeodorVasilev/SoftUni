using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Predicate_For_Names
{
	class Program
	{
		static void Main(string[] args)
		{
			int nameLenght = int.Parse(Console.ReadLine());

			List<string> names = Console.ReadLine().Split().ToList();

			Func<string, bool> filter = x => x.Length <= nameLenght;

			var sorted = names.Where(filter).ToList();

			foreach (var name in sorted)
			{
				Console.WriteLine(name);
			}
		}
	}
}
