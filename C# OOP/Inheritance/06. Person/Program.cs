using System;

namespace _06._Person
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = Console.ReadLine();
			int age = int.Parse(Console.ReadLine());

			Child child = new Child(name, age);

			Console.WriteLine(child);
		}
	}
}
