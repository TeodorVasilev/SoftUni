namespace Vehicles
{
	public class Truck : Vehicle
	{
		private const double airConditionConsumption = 1.6;
		public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) 
			: base(fuelQuantity, fuelConsumption + airConditionConsumption, tankCapacity)
		{

		}

		public override void Refuel(double amount)
		{
			base.Refuel(amount);
			this.FuelQuantity -= amount * 0.05;
		}
	}
}
