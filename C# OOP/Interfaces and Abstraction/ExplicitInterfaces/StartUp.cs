namespace ExplicitInterfaces
{
	using System;

	public class StartUp
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			while (input != "End")
			{
				string[] citizenArgs = input.Split();

				string name = citizenArgs[0];
				string country = citizenArgs[1];
				int age = int.Parse(citizenArgs[2]);

				IPerson person = new Citizen(name, country, age);
				IResident resident = new Citizen(name, country, age);

				Console.WriteLine(person.GetName());
				Console.WriteLine(resident.GetName());

				input = Console.ReadLine();
			}
		}
	}
}
