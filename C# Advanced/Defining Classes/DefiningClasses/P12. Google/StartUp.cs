using System;
using System.Collections.Generic;

namespace P12._Google
{
	class StartUp
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			List<Person> persons = new List<Person>();
			//Dictionary<string, Person> persons = new Dictionary<string, Person>();

			while (input != "End")
			{
				string[] inputParts = input.Split();

				string personName = inputParts[0];

				string type = inputParts[1];

				string companyName;
				string companyDepartment;
				double salary;
				string pokemonName;
				string pokemonElement;
				string parentName;
				string parentBirthDay;
				string childName;
				string childBirthDay;
				string model;
				int speed;
				

				switch(type)
				{
					case "company":
						 companyName = inputParts[2];
						 companyDepartment = inputParts[3];
						 salary = double.Parse(inputParts[4]);
						break;
					case "pokemon":
						 pokemonName = inputParts[2];
						 pokemonElement = inputParts[3];
						break;
					case "parents":
						 parentName = inputParts[2];
						 parentBirthDay = inputParts[3];
						break;
					case "children":
						 childName = inputParts[2];
						 childBirthDay = inputParts[3];
						break;
					case "car":
						 model = inputParts[2];
						 speed = int.Parse(inputParts[3]);
						break;
				}

				input = Console.ReadLine();
			}
		}
	}
}
