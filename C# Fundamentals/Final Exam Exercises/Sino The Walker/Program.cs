namespace Sino_The_Walker
{
    using System;
    using System.Globalization;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string leavingTime = Console.ReadLine();
            int steps = int.Parse(Console.ReadLine()) % 86400;
            int secPerStep = int.Parse(Console.ReadLine()) % 86400;

            long seconds = steps * secPerStep;

            DateTime dt = DateTime.ParseExact(leavingTime, "HH:mm:ss", CultureInfo.InvariantCulture);

            string result = dt.AddSeconds(seconds).ToString("HH:mm:ss");

            Console.WriteLine($"Time Arrival: {result}");
        }
    }
}
