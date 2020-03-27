namespace Battle_Manager
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, int> userHealth = new Dictionary<string, int>();
            Dictionary<string, int> userEnergy = new Dictionary<string, int>();

            while (input != "Results")
            {
                string[] commandArgs = input.Split(":");

                string command = commandArgs[0];

                if(command == "Add")
                {
                    string name = commandArgs[1];
                    int health = int.Parse(commandArgs[2]);
                    int energy = int.Parse(commandArgs[3]);

                    if(!userHealth.ContainsKey(name) && !userEnergy.ContainsKey(name))
                    {
                        userHealth[name] = health;
                        userEnergy[name] = energy;
                    }
                    else
                    {
                        userHealth[name] += health;
                    }

                }
                else if(command == "Attack")
                {
                    string attackerName = commandArgs[1];
                    string defenderName = commandArgs[2];
                    int damage = int.Parse(commandArgs[3]);

                    if(userHealth.ContainsKey(attackerName) && userHealth.ContainsKey(defenderName))
                    {
                        userHealth[defenderName] -= damage;

                        if(userHealth[defenderName] <=0)
                        {
                            userHealth.Remove(defenderName);
                            userEnergy.Remove(defenderName);

                            Console.WriteLine($"{defenderName} was disqualified!");
                        }

                        userEnergy[attackerName] -= 1;

                        if(userEnergy[attackerName] <= 0)
                        {
                            userHealth.Remove(attackerName);
                            userEnergy.Remove(attackerName);

                            Console.WriteLine($"{attackerName} was disqualified!");
                        }
                    }

                }
                else if(command == "Delete")
                {
                    string username = commandArgs[1];

                    if(username == "All")
                    {
                        userHealth.Clear();
                        userEnergy.Clear();
                    }
                    else
                    {
                        userHealth.Remove(username);
                        userEnergy.Remove(username);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"People count: {userHealth.Count}");

            var sorted = userHealth.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            foreach (var kvp in sorted)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} - {userEnergy[kvp.Key]}");
            }
        }
    }
}
