using System;
using System.Collections.Generic;
using System.Linq;

namespace P08._Raw_Data
{
	class StartUp
	{
		static void Main(string[] args)
		{
			int numberOfCars = int.Parse(Console.ReadLine());

			List<Car> cars = new List<Car>();

			for (int i = 0; i < numberOfCars; i++)
			{
				string[] input = Console.ReadLine().Split().ToArray();

				string model = input[0];

				int speed = int.Parse(input[1]);
				int power = int.Parse(input[2]);

				Engine engine = new Engine(speed, power);

				int weight = int.Parse(input[3]);
				string type = input[4];

				Cargo cargo = new Cargo(weight, type);

				Tire[] tires = new Tire[4];

				int index = 5;

				for (int w = 0; w < tires.Length; w++)
				{
					double pressure = double.Parse(input[index]);
					index++;
					int age = int.Parse(input[index]);
					index++;

					Tire tire = new Tire(pressure, age);

					tires[w] = tire;
				}

				Car car = new Car(model, engine, cargo, tires);

				cars.Add(car);
			}

			string command = Console.ReadLine();

			if(command == "fragile")
			{
				cars
				  .Where(c => c.Cargo.Type == "fragile")
				  .Where(c => c.Tires.Any(t => t.Pressure < 1))
				  .ToList()
				  .ForEach(Console.WriteLine);
			}
			else if(command == "flamable")
			{
				cars
					.Where(c => c.Cargo.Type == "flamable")
					.Where(c => c.Engine.Power > 250)
					.ToList()
					.ForEach(Console.WriteLine);
			}
		}
	}
}
