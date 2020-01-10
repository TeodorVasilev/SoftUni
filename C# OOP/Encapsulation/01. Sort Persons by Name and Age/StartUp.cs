namespace _01._Sort_Persons_by_Name_and_Age
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class StartUp
	{
		public static void Main(string[] args)
		{
			int peopleCount = int.Parse(Console.ReadLine());

			var people = new List<Person>();

			for (int i = 0; i < peopleCount; i++)
			{
				var personInfo = Console.ReadLine().Split().ToArray();

				var firstName = personInfo[0];
				var lastName = personInfo[1];
				var age = int.Parse(personInfo[2]);
				var salary = decimal.Parse(personInfo[3]);

				var person = new Person(firstName, lastName, age, salary);

				people.Add(person);
			}
			
			var team = new Team("SoftUni");

			foreach (var person in people)
			{
				team.AddPlayer(person);
			}

			Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
			Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");
		}
	}
}
