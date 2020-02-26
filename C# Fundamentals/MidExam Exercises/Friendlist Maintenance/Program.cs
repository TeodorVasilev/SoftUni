namespace Friendlist_Maintenance
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> friends = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();

            int blacklistedCnt = 0;
            int lostCnt = 0;

            while (input != "Report")
            {
                string[] commandArgs = input.Split();

                string command = commandArgs[0];

                if(command == "Blacklist")
                {
                    string name = commandArgs[1];

                    if(!friends.Contains(name))
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                    else
                    {
                        int index = friends.IndexOf(name);
                        friends[index] = "Blacklisted";
                        blacklistedCnt++;

                        Console.WriteLine($"{name} was blacklisted.");
                    }
                }
                else if(command == "Error")
                {
                    int index = int.Parse(commandArgs[1]);

                    if(index >= 0 && index < friends.Count)
                    {
                        if(friends[index] != "Blacklisted" && friends[index] != "Lost")
                        {
                            Console.WriteLine($"{friends[index]} was lost due to an error.");

                            friends[index] = "Lost";

                            lostCnt++;
                        }
                    }
                }
                else if(command == "Change")
                {
                    int index = int.Parse(commandArgs[1]);

                    string name = commandArgs[2];

                    if (index >= 0 && index < friends.Count)
                    {
                        Console.WriteLine($"{friends[index]} changed his username to {name}.");

                        friends[index] = name;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Blacklisted names: {blacklistedCnt}");
            Console.WriteLine($"Lost names: {lostCnt}");

            Console.WriteLine(string.Join(" ", friends));
        }
    }
}
