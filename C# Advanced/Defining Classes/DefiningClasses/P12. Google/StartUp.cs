using System;
using System.Collections.Generic;
using System.Linq;

namespace P12._Google
{
	class StartUp
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			List<Person> persons = new List<Person>();

			while (input != "End")
			{
				string[] inputParts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

				string personName = inputParts[0];
				int index = persons.FindIndex(p => p.Name == personName);
				string type = inputParts[1];

				if (index >= 0)
				{
					UpdatePersonInfo(persons, inputParts, index, type);
				}
				else
				{
					Person person = new Person(personName);
					AddPersonInfo(persons, inputParts, type, person);
				}

				input = Console.ReadLine();
			}

			input = Console.ReadLine();
			int indexx = persons.FindIndex(p => p.Name == input);
			var result = persons.Where(p => p.Name == input).FirstOrDefault();

			PrintInfo(input, persons, indexx, result);
		}

		static void PrintInfo(string input, List<Person> persons,int index, Person person)
		{
			Console.WriteLine(persons[index]);
			Console.WriteLine("Pokemon:");
			foreach (var pokemon in person.Pokemons)
			{
				Console.WriteLine($"{pokemon.Name} {pokemon.Element}");
			}
			Console.WriteLine("Parents:");
			foreach (var parent in person.Parents)
			{
				Console.WriteLine($"{parent.Name} {parent.Birthday}");
			}
			Console.WriteLine("Children:");
			foreach (var child in person.Children)
			{
				Console.WriteLine($"{child.Name} {child.Birthday}");
			}
			//Console.WriteLine(persons[index].Pokemons);
			//Console.WriteLine(persons[index].Parents);
			//Console.WriteLine(persons[index].Children);
		}

		static void UpdatePersonInfo(List<Person> persons, string[] inputParts, int index, string type)
		{
			switch(type)
			{
				case "company":
					string companyName = inputParts[2];
					string department = inputParts[3];
					double salary = double.Parse(inputParts[4]);

					Company company = new Company(companyName, department, salary);

					persons[index].Company = company;
					break;
				case "car":
					string model = inputParts[2];
					int speed = int.Parse(inputParts[3]);

					Car car = new Car(model, speed);

					persons[index].Car = car;
					break;
				case "pokemon":
					string pokemonName = inputParts[2];
					string element = inputParts[3];

					Pokemon pokemon = new Pokemon(pokemonName, element);

					persons[index].Pokemons.Add(pokemon);
					break;
				case "parents":
					string parentName = inputParts[2];
					string birthday = inputParts[3];

					Parent parent = new Parent(parentName, birthday);

					persons[index].Parents.Add(parent);
					break;
				case "children":
					string childName = inputParts[2];
					string childBirthday = inputParts[3];

					Child child = new Child(childName, childBirthday);

					persons[index].Children.Add(child);
					break;
			}
		}

		static void AddPersonInfo(List<Person> persons, string[] inputParts, string type, Person person)
		{
			switch (type)
			{
				case "company":
					string companyName = inputParts[2];
					string companyDepartment = inputParts[3];
					double salary = double.Parse(inputParts[4]);

					Company company = new Company(companyName, companyDepartment, salary);

					person.Company = company;

					persons.Add(person);
					break;
				case "pokemon":
					string pokemonName = inputParts[2];
					string element = inputParts[3];

					Pokemon pokemon = new Pokemon(pokemonName, element);

					person.Pokemons.Add(pokemon);
					persons.Add(person);
					break;
				case "parents":
					string parentName = inputParts[2];
					string birthday = inputParts[3];

					Parent parent = new Parent(parentName, birthday);

					person.Parents.Add(parent);
					persons.Add(person);
					break;
				case "children":
					string childName = inputParts[2];
					string childBirthday = inputParts[3];

					Child child = new Child(childName, childBirthday);

					person.Children.Add(child);
					persons.Add(person);
					break;
				case "car":
					string model = inputParts[2];
					int speed = int.Parse(inputParts[3]);

					Car car = new Car(model, speed);

					person.Car = car;
					persons.Add(person);
					break;
			}
		}
	}
}
