namespace Legendary_Farming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            Dictionary<string, int> keyMaterialQuantity = new Dictionary<string, int>();
            Dictionary<string, int> junkMaterialQuantity = new Dictionary<string, int>();

            keyMaterialQuantity.Add("shards", 0);
            keyMaterialQuantity.Add("fragments", 0);
            keyMaterialQuantity.Add("motes", 0);

            while (true)
            {
                string[] materialsArgs = input.Split();

                for (int i = 0; i < materialsArgs.Length - 1; i += 2)
                {
                    int quantity = int.Parse(materialsArgs[i]);
                    string material = materialsArgs[i + 1];

                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        //if (!keyMaterialQuantity.ContainsKey(material))
                        //{
                        //    keyMaterialQuantity[material] = 0;
                        //}

                        keyMaterialQuantity[material] += quantity;
                    }
                    else
                    {
                        if (!junkMaterialQuantity.ContainsKey(material))
                        {
                            junkMaterialQuantity[material] = 0;
                        }

                        junkMaterialQuantity[material] += quantity;
                    }

                    
                    if(keyMaterialQuantity.ContainsKey(material))
                    {
                        if (keyMaterialQuantity[material] >= 250)
                        {
                            string item = "";

                            foreach (var kvp in keyMaterialQuantity)
                            {
                                if (kvp.Key == "shards")
                                {
                                    if (kvp.Value >= 250)
                                    {
                                        item = "Shadowmourne";
                                    }
                                }
                                else if (kvp.Key == "fragments")
                                {
                                    if (kvp.Value >= 250)
                                    {
                                        item = "Valanyr";
                                    }
                                }
                                else if (kvp.Key == "motes")
                                {
                                    if (kvp.Value >= 250)
                                    {
                                        item = "Dragonwrath";
                                    }
                                }
                            }

                            if (item != "")
                            {
                                keyMaterialQuantity[material] -= 250;
                            }

                            Console.WriteLine($"{item} obtained!");

                            var sorted = keyMaterialQuantity.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
                            var junkSorted = junkMaterialQuantity.OrderBy(x => x.Key);

                            foreach (var kvp in sorted)
                            {
                                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                            }

                            foreach (var kvp in junkSorted)
                            {
                                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                            }

                            return;
                        }
                    }
                }

                input = Console.ReadLine().ToLower();
            }
        }
    }
}
