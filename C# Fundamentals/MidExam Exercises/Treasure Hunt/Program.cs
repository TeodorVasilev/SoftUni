namespace Treasure_Hunt
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> lootChest = Console.ReadLine().Split("|").ToList();

            string input = Console.ReadLine();

            while (input != "Yohoho!")
            {
                string[] commandArgs = input.Split(' ');

                string command = commandArgs[0];

                if(command == "Loot")
                {
                    for (int i = 1; i < commandArgs.Length; i++)
                    {
                        if(!lootChest.Contains(commandArgs[i]))
                        {
                            lootChest.Insert(0, commandArgs[i]);
                        }
                    }
                }
                else if(command == "Drop")
                {
                    int index = int.Parse(commandArgs[1]);

                    if(index >=0 && index < lootChest.Count)
                    {
                        string item = lootChest[index];

                        lootChest.RemoveAt(index);

                        lootChest.Add(item);
                    }
                }
                else if(command == "Steal")
                {
                    int count = int.Parse(commandArgs[1]);

                    List<string> stolen = new List<string>();

                    if (count >= lootChest.Count)
                    {
                        stolen = lootChest.ToList();

                        Console.WriteLine(string.Join(", ", stolen));

                        lootChest.Clear();
                    }
                    else
                    {
                        stolen = lootChest.TakeLast(count).ToList();

                        int index = lootChest.Count - count;

                        lootChest.RemoveRange(index, count);

                        Console.WriteLine(string.Join(", ", stolen));
                    }
                }

                input = Console.ReadLine();
            }

            double itemsSum = 0;

            if(lootChest.Count > 0)
            {
                foreach (var item in lootChest)
                {
                    itemsSum += item.Length;
                }

                itemsSum /= lootChest.Count;

                Console.WriteLine($"Average treasure gain: {itemsSum:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine($"Failed treasure hunt.");
            }
        }
    }
}
