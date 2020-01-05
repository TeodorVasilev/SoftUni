using System.Text;

namespace P07._Speed_Racing
{
	public class Car
	{
		private string model;

		private double fuelAmount;

		private double fuelConsumptionForOneKm;

		private double traveledDistance;

		public Car(string model, double fuelAmount, double fuelConsumptionForOneKm, double traveledDistance)
		{
			this.Model = model;
			this.FuelAmount = fuelAmount;
			this.FuelConsumptionForOneKm = fuelConsumptionForOneKm;
			this.TraveledDistance = TraveledDistance;
		}

		public double TraveledDistance
		{
			get { return traveledDistance; }
			set { traveledDistance = value; }
		}
		
		public double FuelConsumptionForOneKm
		{
			get { return fuelConsumptionForOneKm; }
			set { fuelConsumptionForOneKm = value; }
		}
		
		public double FuelAmount
		{
			get { return fuelAmount; }
			set { fuelAmount = value; }
		}
		
		public string Model
		{
			get { return model; }
			set { model = value; }
		}
		//disToTravel * fuelforonekm - fuelamount
		public void Drive(double distance)
		{
			double expenceFuel = distance * FuelConsumptionForOneKm;

			if (expenceFuel > FuelAmount)
			{
				System.Console.WriteLine("Insufficient fuel for the drive");
			}
			else
			{
				FuelAmount -= distance * FuelConsumptionForOneKm;
				TraveledDistance += distance;
			}
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append($"{this.Model} {this.FuelAmount:f2} {this.TraveledDistance}");

			return sb.ToString();
		}
	}
}
