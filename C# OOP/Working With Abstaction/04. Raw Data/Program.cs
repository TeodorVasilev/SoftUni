namespace _04._Raw_Data
{
	using Factory;
	using System;

	public class Program
	{
		public static void Main(string[] args)
		{
			int carsCount = int.Parse(Console.ReadLine());

			CarFactory carFactory = new CarFactory();
			EngineFactory engineFactory = new EngineFactory();
			TireFactory tireFactory = new TireFactory();

			CarCatalog carCatalog = new CarCatalog(carFactory, engineFactory, tireFactory);

			for (int i = 0; i < carsCount; i++)
			{
				string[] carArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

				carCatalog.Add(carArgs);
			}

			string command = Console.ReadLine();

			carCatalog.GetCarInfo(command);
		}
	}
}
