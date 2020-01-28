namespace Vehicles
{
	using System;

	public class StartUp
	{
		static void Main(string[] args)
		{
			Car car = null;
			Truck truck = null;
			Bus bus = null;

			for (int i = 0; i < 3; i++)
			{
				string[] vehicleArgs = Console.ReadLine().Split();

				if (vehicleArgs[0] == "Car")
				{
					car = new Car(double.Parse(vehicleArgs[1]), double.Parse(vehicleArgs[2]), double.Parse(vehicleArgs[3]));
				}
				else if(vehicleArgs[0] == "Truck")
				{
					truck = new Truck(double.Parse(vehicleArgs[1]), double.Parse(vehicleArgs[2]), double.Parse(vehicleArgs[3]));
				}
				else if(vehicleArgs[0] == "Bus")
				{
					bus = new Bus(double.Parse(vehicleArgs[1]), double.Parse(vehicleArgs[2]), double.Parse(vehicleArgs[3]));
				}
			}

			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				string[] command = Console.ReadLine().Split();

				if (command[0] == "Drive")
				{
					if (command[1] == "Car")
					{
						double distance = double.Parse(command[2]);
						Console.WriteLine(car.Drive(distance));
					}
					else if (command[1] == "Truck")
					{
						double distance = double.Parse(command[2]);
						Console.WriteLine(truck.Drive(distance));
					}
					else if(command[1] == "Bus")
					{
						double distance = double.Parse(command[2]);
						Console.WriteLine(bus.Drive(distance));
					}
				}
				else if(command[0] == "Refuel")
				{
					try
					{
						if (command[1] == "Car")
						{
							double amount = double.Parse(command[2]);
							car.Refuel(amount);
						}
						else if (command[1] == "Truck")
						{
							double amount = double.Parse(command[2]);
							truck.Refuel(amount);
						}
						else if (command[1] == "Bus")
						{
							double amount = double.Parse(command[2]);
							bus.Refuel(amount);
						}
					}
					catch (ArgumentException ex)
					{
						Console.WriteLine(ex.Message);
					}
				}
				else if(command[0] == "DriveEmpty")
				{
					if (command[1] == "Bus")
					{
						double distance = double.Parse(command[2]);
						Console.WriteLine(bus.Drive(distance));
					}
				}
			}

			Console.WriteLine(car.ToString());
			Console.WriteLine(truck.ToString());
			Console.WriteLine(bus.ToString());
		}
	}
}
