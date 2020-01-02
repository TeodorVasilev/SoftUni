using System;

namespace CarManufacturer
{
	class Program
	{
		static void Main(string[] args)
		{
			Car car = new Car();

			car.Make = "VW";
			car.Model = "MK3";
			car.Year = 1992;
			car.FuelQuantity = 200;
			car.FuelConsumption = 200;
			car.Drive(2000);

			Console.WriteLine(car.GetInformation());

			//Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
		}
	}
}
