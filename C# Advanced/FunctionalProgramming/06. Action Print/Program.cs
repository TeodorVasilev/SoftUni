using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Action_Print
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> names = Console.ReadLine().Split(' ').ToList();

			names.ForEach(delegate (string name)
			{
				Console.WriteLine(name);
			});
		}
	}
}
