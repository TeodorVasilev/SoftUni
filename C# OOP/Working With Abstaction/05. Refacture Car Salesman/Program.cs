namespace _05._Refacture_Car_Salesman
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class Program
	{
		public static void Main(string[] args)
		{
			int engineCount = int.Parse(Console.ReadLine());

			EngineFactory engineFactory = new EngineFactory();

			List<Engine> engines = new List<Engine>();

			for (int i = 0; i < engineCount; i++)
			{
				string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

				var engine = engineFactory.Create(parameters);

				engines.Add(engine);
			}

			int carCount = int.Parse(Console.ReadLine());

			CarFactory carFactory = new CarFactory();

			CarCatalog carCatalog = new CarCatalog();
			
			for (int i = 0; i < carCount; i++)
			{
				string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

				var car = carFactory.Create(parameters, engines);

				carCatalog.Cars.Add(car);
			}

			foreach (var car in carCatalog.Cars)
			{
				Console.WriteLine(car);
			}
		}
	}
}
