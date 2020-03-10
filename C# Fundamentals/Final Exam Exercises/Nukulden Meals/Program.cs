
namespace Nukulden_Meals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> guestMeals = new Dictionary<string, List<string>>();

            int unlikedMeals = 0;

            while (input != "Stop")
            {
                string[] commandArgs = input.Split("-");

                string command = commandArgs[0];
                string guest = commandArgs[1];
                string meal = commandArgs[2];

                if(command == "Like")
                {
                    if(!guestMeals.ContainsKey(guest))
                    {
                        guestMeals[guest] = new List<string>();
                    }

                    if (!guestMeals[guest].Contains(meal))
                    {
                        guestMeals[guest].Add(meal);
                    }
                }
                else if(command == "Unlike")
                {
                    if(guestMeals.ContainsKey(guest))
                    {
                        if(guestMeals[guest].Contains(meal))
                        {
                            guestMeals[guest].Remove(meal);
                            Console.WriteLine($"{guest} doesn't like the {meal}.");
                            unlikedMeals++;
                        }
                        else
                        {
                            Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                }

                input = Console.ReadLine();
            }

            var sorted = guestMeals.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key);

            foreach (var kvp in sorted)
            {
                Console.WriteLine($"{kvp.Key}: {string.Join(", ", kvp.Value)}");
            }

            Console.WriteLine($"Unliked meals: {unlikedMeals}");
        }
    }
}
