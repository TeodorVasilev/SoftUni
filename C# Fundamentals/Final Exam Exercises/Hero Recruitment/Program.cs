using System;
using System.Collections.Generic;
using System.Linq;

namespace Hero_Recruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> heroesSpells = new Dictionary<string, List<string>>();

            while (input != "End")
            {
                string[] commandArgs = input.Split();

                string command = commandArgs[0];
                string name = commandArgs[1];

                if(command == "Enroll")
                {
                    if(!heroesSpells.ContainsKey(name))
                    {
                        heroesSpells.Add(name, new List<string>());
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already enrolled.");
                    }
                }
                else if(command == "Learn")
                {
                    string spell = commandArgs[2];

                    if (!heroesSpells.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} doesn't exist.");
                    }
                    else
                    {
                        if (!heroesSpells[name].Contains(spell))
                        {
                            heroesSpells[name].Add(spell);
                        }
                        else
                        {
                            Console.WriteLine($"{name} has already learnt {spell}.");
                        }
                    }
                }
                else if(command == "Unlearn")
                {
                    string spell = commandArgs[2];

                    if (!heroesSpells.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} doesn't exist.");
                    }
                    else
                    {
                        if (!heroesSpells[name].Contains(spell))
                        {
                            Console.WriteLine($"{name} doesn't know {spell}.");
                        }
                        else
                        {
                            heroesSpells[name].Remove(spell);
                        }
                    }

                }

                input = Console.ReadLine();
            }

            var sorted = heroesSpells.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key);

            Console.WriteLine("Heroes:");
            foreach (var kvp in sorted)
            {
                Console.WriteLine($"== {kvp.Key}: {string.Join(", ", kvp.Value)}");
            }
        }
    }
}
