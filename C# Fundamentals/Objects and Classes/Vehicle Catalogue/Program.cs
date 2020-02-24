namespace Vehicle_Catalogue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Car
    {
        public Car(string model, string color, double horsePower)
        {
            this.Type = "Car";
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }

        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public double HorsePower { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Type: {this.Type}");
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"Color: {this.Color}");
            sb.Append($"Horsepower: {this.HorsePower}");

            return sb.ToString();
        }
    }

    public class Truck
    {
        public Truck(string model, string color, double horsePower)
        {
            this.Type = "Truck";
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }

        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public double HorsePower { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Type: {this.Type}");
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"Color: {this.Color}");
            sb.Append($"Horsepower: {this.HorsePower}");

            return sb.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            while (input != "End")
            {
                string[] vehicleArgs = input.Split();

                string vehicleType = vehicleArgs[0].ToLower();
                string vehicleModel = vehicleArgs[1];
                string vehicleColor = vehicleArgs[2].ToLower();
                double horsePower = double.Parse(vehicleArgs[3]);

                if(vehicleType == "car")
                {
                    Car car = new Car(vehicleModel, vehicleColor, horsePower);

                    cars.Add(car);
                }
                else if(vehicleType == "truck")
                {
                    Truck truck = new Truck(vehicleModel, vehicleColor, horsePower);

                    trucks.Add(truck);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Close the Catalogue")
            {
                string model = input;

                if (cars.Select(c => c.Model).Contains(model))
                {
                    Car car = cars.FirstOrDefault(c => c.Model == model);

                    Console.WriteLine(car);
                }
                else if(trucks.Select(t => t.Model).Contains(model))
                {
                    Truck truck = trucks.FirstOrDefault(t => t.Model == model);

                    Console.WriteLine(truck);
                }

                input = Console.ReadLine();
            }

            if(cars.Count > 0)
            {
                double carsAvgHp = cars.Select(c => c.HorsePower).Sum() / cars.Count;
                Console.WriteLine($"Cars have average horsepower of: {carsAvgHp:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if(trucks.Count > 0)
            {
                double trucksAvgHp = trucks.Select(c => c.HorsePower).Sum() / trucks.Count;
                Console.WriteLine($"Trucks have average horsepower of: {trucksAvgHp:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
        }
    }
}
