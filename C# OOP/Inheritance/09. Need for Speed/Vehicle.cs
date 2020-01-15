namespace NeedForSpeed
{
	public class Vehicle
	{
		private const double defaultFuelConsumption = 1.25;

		public Vehicle(int horsePower, double fuel)
		{
			this.HorsePower = horsePower;
			this.Fuel = fuel;
		}

		public int HorsePower { get; private set; }

		public double Fuel { get; private set; }
		
		public virtual double FuelConsumption
			=> defaultFuelConsumption;

		public virtual void Drive(double kilometers)
		{
			bool canDrive = this.Fuel - kilometers * this.FuelConsumption >= 0;

			if (canDrive)
			{
				this.Fuel -= kilometers * this.FuelConsumption;
			}
		}
	}
}
