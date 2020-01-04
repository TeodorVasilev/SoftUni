using System;
using System.Collections.Generic;
using System.Linq;

namespace P01._Define_Class_Person
{
	public class StartUp
	{
		public static void Main(string[] args)
		{
			int peopleCount = int.Parse(Console.ReadLine());

			List<Person> persons = new List<Person>();

			for (int i = 0; i < peopleCount; i++)
			{
				string[] peopleArgs = Console.ReadLine().Split();

				string name = peopleArgs[0];

				int age = int.Parse(peopleArgs[1]);

				Person person = new Person(name, age);

				persons.Add(person);
			}

			var sorted = persons.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();

			foreach (var person in sorted)
			{
				Console.WriteLine(person);
			}
		}
	}
}
