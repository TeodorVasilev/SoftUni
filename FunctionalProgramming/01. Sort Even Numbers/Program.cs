using System;
using System.Linq;

namespace _01.Sort_Even_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(string.Join(", ", Console.ReadLine().Split(new char[] {',',' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Where(n => n % 2 == 0).OrderBy(n => n).ToList()));
		}
	}
}
