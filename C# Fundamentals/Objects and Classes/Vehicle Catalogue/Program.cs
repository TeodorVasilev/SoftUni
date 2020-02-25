namespace Vehicle_Catalogue
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Vehicle> vehicles = new List<Vehicle>();

            while (input != "End")
            {
                string[] vehicleArgs = input.Split();

                string type = vehicleArgs[0];
                type = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(type);
                string model = vehicleArgs[1];
                string color = vehicleArgs[2];
                double horsePower = double.Parse(vehicleArgs[3]);

                Vehicle vehicle = new Vehicle(type, model, color, horsePower);

                vehicles.Add(vehicle);

                input = Console.ReadLine();
            }

            string vehicleModel = Console.ReadLine();

            while (vehicleModel != "Close the Catalogue")
            {
                foreach (var vehicle in vehicles)
                {
                    if (vehicle.Model == vehicleModel)
                    {
                        Console.WriteLine(vehicle);
                    }
                }

                vehicleModel = Console.ReadLine();
            }

            var cars = vehicles.Where(v => v.Type == "Car").ToList();
            var trucks = vehicles.Where(v => v.Type == "Truck").ToList();

            if (cars.Count > 0)
            {
                double avgHp = cars.Select(c => c.HorsePower).Sum() / cars.Count;


                Console.WriteLine($"Cars have average horsepower of: {avgHp:f2}.");

            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:F2}.");
            }

            if (trucks.Count > 0)
            {
                double avgHp = trucks.Select(t => t.HorsePower).Sum() / trucks.Count;


                Console.WriteLine($"Trucks have average horsepower of: {avgHp:f2}.");

            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:F2}.");
            }
        }
    }
}
