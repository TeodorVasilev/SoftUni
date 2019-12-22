using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Unique_Usernames
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			var names = new HashSet<string>();

			for (int i = 0; i < n; i++)
			{
				var name = Console.ReadLine();

				names.Add(name);
			}

			foreach (var name in names)
			{
				Console.WriteLine(name);
			}
		}
	}
}
