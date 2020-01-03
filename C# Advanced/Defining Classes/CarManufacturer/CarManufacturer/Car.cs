namespace CarManufacturer
{
	public class Car
	{
		private string make;
		private string model;
		private int year;
		private double fuelQuantity;
		private double fuelConsumption;
		private Engine engine;
		private Tire[] tires;

		public Car()
		:this("VW", "Golf", 2025, 200, 10)
		{
		}

		public Car(string make, string model, int year)
			: this(make, model, year, 200, 10)
		{
		}

		public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
		{
			this.Make = make;
			this.Model = model;
			this.Year = year;
			this.FuelQuantity = fuelQuantity;
			this.FuelConsumption = fuelConsumption;
		}

		public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
			:this (make, model, year, fuelQuantity, fuelConsumption)
		{
			this.Engine = engine;
			this.Tires = tires;
		}

		public string Make { get; set; }

		public string Model { get; set; }

		public int Year { get; set; }

		public double FuelQuantity { get; set; }

		public double FuelConsumption { get; set; }

		public Engine Engine { get; set; }

		public Tire[] Tires  { get; set; }
		
		public void Drive(double distance)
		{
			double expenceFuel = FuelConsumption * distance / 100;

			if (expenceFuel > FuelQuantity)
			{
				System.Console.WriteLine("Not enough fuel to perform this trip!");
			}
			else
			{
				FuelQuantity -= distance / 100 * FuelConsumption;
			}
		}

		public string GetInformation()
		{
			var sb = new System.Text.StringBuilder();
			sb.AppendLine($"Make: {this.Make}");
			sb.AppendLine($"Model: {this.Model}");
			sb.AppendLine($"Year: {this.Year}");
			sb.Append($"Fuel: {this.FuelQuantity:F2}L");
			return sb.ToString();
		}
	}
}
