using System;
using System.Collections.Generic;
using System.Linq;

namespace P10._Car_Salesman
{
	class StartUp
	{
		static void Main(string[] args)
		{
			int engineCount = int.Parse(Console.ReadLine());

			List<Engine> engines = new List<Engine>();

			for (int i = 0; i < engineCount; i++)
			{
				string[] engineArgs = Console.ReadLine().Split().ToArray();

				string model = engineArgs[0];
				int power = int.Parse(engineArgs[1]);

				Engine engine = null;

				if (engineArgs.Length == 2)
				{
					engine = new Engine(model, power);
				}
				else if (engineArgs.Length == 4)
				{
					int displacement = int.Parse(engineArgs[2]);
					string efficiency = engineArgs[3];

					engine = new Engine(model, power, displacement, efficiency);
				}
				else
				{
					bool isDisplacement = int.TryParse(engineArgs[2], out int displacement);

					if(isDisplacement)
					{
						engine = new Engine(model, power, displacement);
					}
					else
					{
						engine = new Engine(model, power, engineArgs[2]);
					}
				}

				engines.Add(engine);
			}

			int carsCount = int.Parse(Console.ReadLine());

			List<Car> cars = new List<Car>();

			for (int i = 0; i < carsCount; i++)
			{
				string[] carArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

				string model = carArgs[0];
				string engineModel = carArgs[1];

				Car car = null;

				Engine engine = engines.Where(x => x.Model == engineModel).FirstOrDefault();

				if(carArgs.Length == 2)
				{
					car = new Car(model, engine);
				}
				else if(carArgs.Length == 4)
				{
					int weight = int.Parse(carArgs[2]);
					string color = carArgs[3];

					car = new Car(model, engine, weight, color);
				}
				else
				{
					bool isWeight = int.TryParse(carArgs[2], out int weight);
					
					if(isWeight)
					{
						car = new Car(model, engine, weight);
					}
					else
					{
						car = new Car(model, engine, carArgs[2]);
					}
				}

				cars.Add(car);
			}

			cars.ForEach(Console.WriteLine);
		}
	}
}
