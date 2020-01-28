namespace Vehicles
{
	public class Bus : Vehicle
	{
		private const double airConditionConsumption = 1.4;
		public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
			: base(fuelQuantity, fuelConsumption + airConditionConsumption, tankCapacity)
		{

		}

		public string DriveEmpty(double distance)
		{
			this.FuelConsumption -= airConditionConsumption;

			return base.Drive(distance);
		}
	}
}
