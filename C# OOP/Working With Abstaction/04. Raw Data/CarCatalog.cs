namespace _04._Raw_Data
{
	using Factory;
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class CarCatalog
	{
		private List<Car> cars;
		private CarFactory carFactory;
		private EngineFactory engineFactory;
		private TireFactory tireFactory;

		public CarCatalog(CarFactory carFactory, EngineFactory engineFactory, TireFactory tireFactory)
		{
			this.cars = new List<Car>();
			this.carFactory = carFactory;
			this.engineFactory = engineFactory;
			this.tireFactory = tireFactory;
		}

		public void Add(string[] carArgs)
		{
			string model = carArgs[0];

			int engineSpeed = int.Parse(carArgs[1]);
			int enginePower = int.Parse(carArgs[2]);

			Engine engine = engineFactory.Create(engineSpeed, enginePower);

			int cargoWeight = int.Parse(carArgs[3]);
			string cargoType = carArgs[4];

			Cargo cargo = new Cargo(cargoWeight, cargoType);

			Tire[] tires = new Tire[4];

			int tireIndex = 5;

			for (int t = 0; t < tires.Length; t++)
			{
				double tirePressure = double.Parse(carArgs[tireIndex]);
				tireIndex++;
				int tireAge = int.Parse(carArgs[tireIndex]);
				tireIndex++;

				Tire tire = tireFactory.Create(tirePressure, tireIndex);

				tires[t] = tire;
			}

			Car car = carFactory.Create(model, engine, cargo, tires);

			cars.Add(car);
		}

		public void GetCarInfo(string command)
		{
			if (command == "fragile")
			{
				List<string> fragile = this.GetCars()
					.Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(y => y.Pressure < 1))
					.Select(x => x.Model)
					.ToList();

				Console.WriteLine(string.Join(Environment.NewLine, fragile));
			}
			else
			{
				List<string> flamable = this.GetCars()
					.Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250)
					.Select(x => x.Model)
					.ToList();

				Console.WriteLine(string.Join(Environment.NewLine, flamable));
			}
		}

		public List<Car> GetCars()
		{
			return this.cars;
		}
	}
}
