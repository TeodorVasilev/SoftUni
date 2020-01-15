namespace Animals
{
	using System;
	using System.Collections.Generic;

	public class StartUp
	{
		public static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string[] animalArgs = Console.ReadLine().Split(' ');

			List<Animal> animals = new List<Animal>();

			while (input != "Beast!")
			{
				string name = animalArgs[0];
				int age = int.Parse(animalArgs[1]);
				string gender = animalArgs[2];

				try
				{
					switch (input)
					{
						case "Cat":
							Cat cat = new Cat(name, age, gender);
							animals.Add(cat);
							break;
						case "Dog":
							Dog dog = new Dog(name, age, gender);
							animals.Add(dog);
							break;
						case "Frog":
							Frog frog = new Frog(name, age, gender);
							animals.Add(frog);
							break;
						case "Kitten":
							Kitten kitten = new Kitten(name, age);
							animals.Add(kitten);
							break;
						case "Tomcat":
							Tomcat tomcat = new Tomcat(name, age);
							animals.Add(tomcat);
							break;
					}
				}
				catch (ArgumentException ex)
				{
					Console.WriteLine(ex.Message);
				}

				input = Console.ReadLine();

				if (input != "Beast!")
				{
					animalArgs = Console.ReadLine().Split(' ');
				}
			}

			foreach (var Animal in animals)
			{
				Console.WriteLine(Animal);
			}
		}
	}
}
