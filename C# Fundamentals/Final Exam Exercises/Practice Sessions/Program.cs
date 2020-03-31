namespace Practice_Sessions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> roadsRacers = new Dictionary<string, List<string>>();

            while (input != "END")
            {
                string[] commandArgs = input.Split("->");

                string command = commandArgs[0];

                if(command == "Add")
                {
                    string road = commandArgs[1];
                    string racer = commandArgs[2];

                    if(!roadsRacers.ContainsKey(road))
                    {
                        roadsRacers[road] = new List<string>();
                        roadsRacers[road].Add(racer);
                    }
                    else
                    {
                        roadsRacers[road].Add(racer);
                    }
                }
                else if(command == "Move")
                {
                    string currentRoad = commandArgs[1];
                    string racer = commandArgs[2];
                    string nextRoad = commandArgs[3];

                    if(roadsRacers[currentRoad].Contains(racer))
                    {
                        roadsRacers[currentRoad].Remove(racer);

                        roadsRacers[nextRoad].Add(racer);
                    }
                }
                else if(command == "Close")
                {
                    string road = commandArgs[1];

                    roadsRacers.Remove(road);
                }

                input = Console.ReadLine();
            }

            var sorted = roadsRacers.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key);

            Console.WriteLine("Practice sessions:");

            foreach (var road in sorted)
            {
                Console.WriteLine(road.Key);

                foreach (var racer in road.Value)
                {
                    Console.WriteLine($"++{racer}");
                }
            }
        }
    }
}
