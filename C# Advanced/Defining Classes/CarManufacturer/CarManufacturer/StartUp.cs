using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
	public class StartUp
	{
		public static void Main()
		{
			string input = Console.ReadLine();

			List<Tire[]> tires = new List<Tire[]>();

			List<double> tirePressure = new List<double>();
			//Dictionary<Tire[], double> tiresPressure = new Dictionary<Tire[], double>();

			while (input != "No more tires")
			{
				var wheels = new Tire[4];

				double pressureSum = 0;

				for (int i = 0; i < 4; i++)
				{
					var inputParts = input.Split();

					int year = int.Parse(inputParts[0]);

					double pressure = double.Parse(inputParts[1]);

					pressureSum += pressure;

					Tire tire = new Tire(year, pressure);

					wheels[i] = tire;
				}

				tires.Add(wheels);

				tirePressure.Add(pressureSum);

				input = Console.ReadLine();
			}

			List<Engine> engines = new List<Engine>();

			input = Console.ReadLine();

			while (input != "Engines done")
			{
				var inputParts = input.Split();

				int horsePower = int.Parse(inputParts[0]);

				double cubicCapacity = double.Parse(inputParts[1]);

				Engine engine = new Engine(horsePower, cubicCapacity);

				engines.Add(engine);

				input = Console.ReadLine();
			}

			List<Car> cars = new List<Car>();

			input = Console.ReadLine();

			while (input != "Show special")
			{
				var inputParts = input.Split();

				string make = inputParts[0];
				string model = inputParts[1];
				int year = int.Parse(inputParts[2]);
				double fuelQuantity = double.Parse(inputParts[3]);
				double fuelConsumption = double.Parse(inputParts[4]);
				int engineIndex = int.Parse(inputParts[5]);
				int tireIndex = int.Parse(inputParts[6]);
				double tirePressureSum = tirePressure[tireIndex];

				Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tireIndex], tirePressureSum);
				
				cars.Add(car);

				input = Console.ReadLine();
			}

			var specialCars = cars.Where(x => x.Year >= 2017).Where(x => x.Engine.HorsePower > 330).Where(x => x.TirePressureSum >= 9 || x.TirePressureSum <= 10).ToList();

			foreach (var car in specialCars)
			{
				Console.WriteLine(car.GetInformation());
			}

			//	string make = Console.ReadLine();
			//	string model = Console.ReadLine();
			//	int year = int.Parse(Console.ReadLine());
			//	double fuelQuantity = double.Parse(Console.ReadLine());
			//	double fuelConsumption = double.Parse(Console.ReadLine());

			//	Car firstCar = new Car();
			//	Car secondCar = new Car(make, model, year);
			//	Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);

			//var tires = new Tire[4] 
			//{
			//	new Tire(1, 2.5),
			//	new Tire(1, 2.1),
			//	new Tire(2, 0.5),
			//	new Tire(2, 2.3)
			//};

			//var engine = new Engine(560, 6300);

			//var car = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);	
		}
	}
}
