using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._Speed_Racing
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberOfCars = int.Parse(Console.ReadLine());

			List<Car> cars = new List<Car>();

			for (int i = 0; i < numberOfCars; i++)
			{
				string[] carArgs = Console.ReadLine().Split().ToArray();

				string model = carArgs[0];
				double fuelAmount = double.Parse(carArgs[1]);
				double fuelConsumptionForOneKm = double.Parse(carArgs[2]);

				Car car = new Car(model, fuelAmount, fuelConsumptionForOneKm, 0);

				cars.Add(car);
			}

			string input = Console.ReadLine();

			while (input != "End")
			{
				string[] inputParts = input.Split();

				string model = inputParts[1];
				double distance = double.Parse(inputParts[2]);

				Car car = cars.Single(c => c.Model == model);

				car.Drive(distance);

				input = Console.ReadLine();
			}

			cars.ForEach(Console.WriteLine);
		}
	}
}
