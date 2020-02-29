using System;

namespace National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstDeskPeople = int.Parse(Console.ReadLine());
            int secondDeskPeople = int.Parse(Console.ReadLine());
            int thirdDeskPeople = int.Parse(Console.ReadLine());
            int totalPeopleCount = int.Parse(Console.ReadLine());

            int peoplePerHour = firstDeskPeople + secondDeskPeople + thirdDeskPeople;
            int hours = 0;

            int serviced = 0;

            while (totalPeopleCount > 0)
            {
                serviced += peoplePerHour;
                totalPeopleCount -= peoplePerHour;
                hours++;

                if(hours % 4 == 0)
                {
                    hours++;
                    continue;
                }
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
