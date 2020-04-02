namespace Hornet_Wings
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double distanceTravelled = (wingFlaps / 1000) * distance;
            double time = wingFlaps / 100;
            double rest = (wingFlaps / endurance) * 5;
            double totalTime = time + rest;

            Console.WriteLine($"{distanceTravelled:f2} m.");
            Console.WriteLine($"{totalTime} s.");
        }
    }
}
