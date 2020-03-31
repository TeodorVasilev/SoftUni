namespace Concert
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, HashSet<string>> bandMembers = new Dictionary<string, HashSet<string>>();
            Dictionary<string, int> bandTime = new Dictionary<string, int>();

            while (input != "start of concert")
            {
                string[] commandArgs = input.Split(new string[] {"; ", ", "}, StringSplitOptions.RemoveEmptyEntries);

                string command = commandArgs[0];

                if (command == "Add")
                {
                    string bandName = commandArgs[1];

                    if(bandMembers.ContainsKey(bandName))
                    {
                        for (int i = 2; i < commandArgs.Length; i++)
                        {
                            bandMembers[bandName].Add(commandArgs[i]);
                        }

                        if(!bandTime.ContainsKey(bandName))
                        bandTime.Add(bandName, 0);
                    }
                    else
                    {
                        bandMembers[bandName] = new HashSet<string>();

                        for (int i = 2; i < commandArgs.Length; i++)
                        {
                            bandMembers[bandName].Add(commandArgs[i]);
                        }

                        bandTime.Add(bandName, 0);
                    }
                }
                else if(command == "Play")
                {
                    string bandName = commandArgs[1];
                    int time = int.Parse(commandArgs[2]);

                    if(bandTime.ContainsKey(bandName))
                    {
                        bandTime[bandName] += time;
                    }
                    else
                    {
                        bandMembers[bandName] = new HashSet<string>();
                        bandTime.Add(bandName, time);
                    }
                }

                input = Console.ReadLine();
            }

            string band = Console.ReadLine();

            var sorted = bandTime.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            Console.WriteLine($"Total time: {sorted.Sum(x => x.Value)}");

            foreach (var kvp in sorted)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

            Console.WriteLine(band);

            foreach (var member in bandMembers[band])
            {
                Console.WriteLine($"=> {member}");
            }
        }
    }
}
