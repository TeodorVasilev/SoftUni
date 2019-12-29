using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Filter_By_Age
{
	public class Person
	{
		public string Name { get; set; }

		public int Age { get; set; }
	}

	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			var people = new List<Person>();

			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
				var name = input[0];
				var age = int.Parse(input[1]);

				var person = new Person
				{
					Name = name,
					Age = age
				};

				people.Add(person);
			}

			string condition = Console.ReadLine();
			int ageCondition = int.Parse(Console.ReadLine());
			

			Func<Person, bool> filterPredicate;

			if(condition == "older")
			{
				filterPredicate = p => p.Age >= ageCondition;
			}
			else
			{
				filterPredicate = p => p.Age < ageCondition;
			}

			string format = Console.ReadLine();

			Func<Person, string> printFunc;

			if(format == "name age")
			{
				printFunc = p => $"{p.Name} - {p.Age}";
			}
			else if(format == "name")
			{
				printFunc = p => $"{p.Name}";
			}
			else
			{
				printFunc = p => $"{p.Age}";
			}

			people.Where(filterPredicate).Select(printFunc).ToList().ForEach(Console.WriteLine);
		}
	}
}
