using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_GreedyTimes
{

    public class Potato
    {
        static void Main(string[] args)
        {
            long bagCapacity = long.Parse(Console.ReadLine());
            string[] itemQuantity = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var itemItemNameQuantity = new Dictionary<string, Dictionary<string, long>>();
            long gold = 0;
            long gems = 0;
            long cash = 0;

            for (int i = 0; i < itemQuantity.Length; i += 2)
            {
                string name = itemQuantity[i];
                long quantity = long.Parse(itemQuantity[i + 1]);

                string type = string.Empty;

                if (name.Length == 3)
                {
                    type = "Cash";
                }
                else if (name.ToLower().EndsWith("gem"))
                {
                    type = "Gem";
                }
                else if (name.ToLower() == "gold")
                {
                    type = "Gold";
                }

                if (type == "")
                {
                    continue;
                }
                else if (bagCapacity < itemItemNameQuantity.Values.Select(x => x.Values.Sum()).Sum() + quantity)
                {
                    continue;
                }

                switch (type)
                {
                    case "Gem":
                        if (!itemItemNameQuantity.ContainsKey(type))
                        {
                            if (itemItemNameQuantity.ContainsKey("Gold"))
                            {
                                if (quantity > itemItemNameQuantity["Gold"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (itemItemNameQuantity[type].Values.Sum() + quantity > itemItemNameQuantity["Gold"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                    case "Cash":
                        if (!itemItemNameQuantity.ContainsKey(type))
                        {
                            if (itemItemNameQuantity.ContainsKey("Gem"))
                            {
                                if (quantity > itemItemNameQuantity["Gem"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (itemItemNameQuantity[type].Values.Sum() + quantity > itemItemNameQuantity["Gem"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                }

                if (!itemItemNameQuantity.ContainsKey(type))
                {
                    itemItemNameQuantity[type] = new Dictionary<string, long>();
                }

                if (!itemItemNameQuantity[type].ContainsKey(name))
                {
                    itemItemNameQuantity[type][name] = 0;
                }

                itemItemNameQuantity[type][name] += quantity;
                if (type == "Gold")
                {
                    gold += quantity;
                }
                else if (type == "Gem")
                {
                    gems += quantity;
                }
                else if (type == "Cash")
                {
                    cash += quantity;
                }
            }

            foreach (var x in itemItemNameQuantity)
            {
                Console.WriteLine($"<{x.Key}> ${x.Value.Values.Sum()}");
                foreach (var item in x.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
                {
                    Console.WriteLine($"##{item.Key} - {item.Value}");
                }
            }
        }
    }
}