namespace Vehicles
{
	using System;

	public abstract class Vehicle
	{
		private double fuelQuantity;
		private double fuelConsumption;
		private double tankCapacity;

		public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
		{
			this.TankCapacity = tankCapacity;
			this.FuelQuantity = fuelQuantity;
			this.FuelConsumption = fuelConsumption;
		}

		public double TankCapacity
		{
			get => this.tankCapacity;

			private set
			{
				if(value <= 0)
				{
					throw new ArgumentException("Capacity cannot be negative or zero");
				}

				this.tankCapacity = value;
			}
		}

		public double FuelQuantity
		{
			get => this.fuelQuantity;

			protected set
			{
				if(value > this.TankCapacity)
				{
					this.FuelQuantity = 0;
				}
				else
				{
					this.fuelQuantity = value;
				}
			}
		}

		public double FuelConsumption
		{
			get => this.fuelConsumption;

			protected set
			{
				if(value <= 0)
				{
					throw new ArgumentException("Consumption cannot be negative or zero");
				}

				this.fuelConsumption = value;
			}
		}

		public string Drive(double distance)
		{
			double neededFuel = distance * this.FuelConsumption;
			string type = this.GetType().Name;

			if(this.FuelQuantity >= neededFuel)
			{
				this.FuelQuantity -= neededFuel;
				return $"{type} travelled {distance} km";
			}
			else
			{
				return $"{type} needs refueling";
			}
		}

		public virtual void Refuel(double amount)
		{
			if(amount + this.FuelQuantity > this.tankCapacity)
			{
				throw new ArgumentException($"Cannot fit {amount} fuel in the tank");
			}
			else if(amount <= 0)
			{
				throw new ArgumentException("Fuel must be a positive number");
			}
			else if(amount + this.FuelQuantity <= tankCapacity)
			{
				this.FuelQuantity += amount;
			}
		}

		public override string ToString()
		{
			return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
		}
	}
}
