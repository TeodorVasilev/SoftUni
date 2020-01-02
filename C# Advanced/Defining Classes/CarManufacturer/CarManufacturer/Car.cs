namespace CarManufacturer
{
	public class Car
	{
		private string make;
		private string model;
		private int year;
		private double fuelQuantity;
		private double fuelConsumption;

		public Car()
		{

		}

		public Car(string make, string model, int year)
		{
			this.Make = make;
			this.Model = model;
			this.Year = year;
		}

		public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
			: this(make, model, year)
		{
			this.FuelConsumption = fuelConsumption;
			this.FuelQuantity = fuelQuantity;
		}

		public string Make { get; set; }

		public string Model { get; set; }

		public int Year { get; set; }

		public double FuelQuantity { get; set; }

		public double FuelConsumption { get; set; }

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
