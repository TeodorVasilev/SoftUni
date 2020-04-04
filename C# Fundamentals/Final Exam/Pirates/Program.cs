namespace Pirates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, int> cityPop = new Dictionary<string, int>();
            Dictionary<string, int> cityGold = new Dictionary<string, int>();

            while (input != "Sail")
            {
                string[] commandArgs = input.Split("||", StringSplitOptions.RemoveEmptyEntries);

                string city = commandArgs[0];
                int population = int.Parse(commandArgs[1]);
                int gold = int.Parse(commandArgs[2]);

                if (!cityPop.ContainsKey(city))
                {
                    cityPop[city] = population;
                }
                else
                {
                    cityPop[city] += population;
                }

                if (!cityGold.ContainsKey(city))
                {
                    cityGold[city] = gold;
                }
                else
                {
                    cityGold[city] += gold;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                string[] eventArgs = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string @event = eventArgs[0];

                if (@event == "Plunder")
                {
                    string city = eventArgs[1];
                    int people = int.Parse(eventArgs[2]);
                    int gold = int.Parse(eventArgs[3]);

                    if (cityPop.ContainsKey(city))
                    {
                        cityPop[city] -= people;
                        cityGold[city] -= gold;
                        Console.WriteLine($"{city} plundered! {gold} gold stolen, {people} citizens killed.");

                        if(cityPop[city] <= 0 || cityGold[city] <= 0)
                        {
                            cityGold.Remove(city);
                            cityPop.Remove(city);
                            Console.WriteLine($"{city} has been wiped off the map!");
                        }
                    }
                }
                else if (@event == "Prosper")
                {
                    string city = eventArgs[1];
                    int gold = int.Parse(eventArgs[2]);

                    if(gold <= 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        input = Console.ReadLine();
                        continue;
                    }

                    if(cityGold.ContainsKey(city))
                    {
                        cityGold[city] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {city} now has {cityGold[city]} gold.");
                    }
                }

                input = Console.ReadLine();
            }

            var sorted = cityGold.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            if(cityGold.Count != 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cityGold.Count} wealthy settlements to go to:");

                foreach (var town in sorted)
                {
                    Console.WriteLine($"{town.Key} -> Population: {cityPop[town.Key]} citizens, Gold: {town.Value} kg");
                }
            }
        }
    }
}
