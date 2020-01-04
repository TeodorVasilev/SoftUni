using P03._Oldest_Family_Member;
using System;
using System.Collections.Generic;

namespace P01._Define_Class_Person
{
	public class StartUp
	{
		public static void Main(string[] args)
		{
			int familyMembers = int.Parse(Console.ReadLine());

			Family family = new Family();

			for (int i = 0; i < familyMembers; i++)
			{
				string input = Console.ReadLine();

				var inputParts = input.Split();
				
				string name = inputParts[0];
				int age = int.Parse(inputParts[1]);

				Person person = new Person(name, age);

				family.AddMember(person);
			}

			Person oldestMember = family.GetOldestMember();

			Console.WriteLine(oldestMember);
		}	
	} 
}
