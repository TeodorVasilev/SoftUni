namespace Ferrari
{
	public class Ferrari : ICar
	{
		private const string defaultModel = "488-Spider";

		public Ferrari(string driverName)
		{
			this.DriverName = driverName;
			this.Model = defaultModel;
		}

		public string DriverName { get; private set; }

		public string Model { get; private set; }

		public string Accelerate()
		{
			return "Gas!";
		}

		public string Brake()
		{
			return "Brakes!";
		}

		public override string ToString()
		{
			return $"{this.Model}/{this.Brake()}/{this.Accelerate()}/{this.DriverName}";
		}
	}
}
