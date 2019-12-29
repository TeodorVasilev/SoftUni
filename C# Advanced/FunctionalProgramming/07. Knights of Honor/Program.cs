using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Knights_of_Honor
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> names = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

			names.ForEach(delegate (string name)
			{
				Console.WriteLine($"Sir {name}");
			});
		}
	}
}
