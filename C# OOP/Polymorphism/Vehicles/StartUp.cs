namespace Vehicles
{
	using System;

	public class StartUp
	{
		static void Main(string[] args)
		{
			string[] carArgs = Console.ReadLine().Split();

			Car car = new Car(double.Parse(carArgs[1]), double.Parse(carArgs[2]), double.Parse(carArgs[3]));

			string[] truckArgs = Console.ReadLine().Split();

			Truck truck = new Truck(double.Parse(truckArgs[1]), double.Parse(truckArgs[2]), double.Parse(truckArgs[3]));

			string[] busArgs = Console.ReadLine().Split();

			Bus bus = new Bus(double.Parse(busArgs[1]), double.Parse(busArgs[2]), double.Parse(busArgs[3]));

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
