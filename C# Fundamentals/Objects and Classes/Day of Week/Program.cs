namespace Day_of_Week
{
    using System;
    using System.Globalization;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            DateTime date = new DateTime();

            date = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
