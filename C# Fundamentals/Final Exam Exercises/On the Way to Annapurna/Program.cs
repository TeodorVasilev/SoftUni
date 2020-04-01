namespace On_the_Way_to_Annapurna
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> storeItems = new Dictionary<string, List<string>>();

            while (input != "END")
            {
                string[] commandArgs = input.Split(new string[] { "->", "," }, StringSplitOptions.RemoveEmptyEntries);

                string command = commandArgs[0];

                if(command == "Add")
                {
                    string store = commandArgs[1];

                    if(!storeItems.ContainsKey(store))
                    {
                        storeItems[store] = new List<string>();

                        for (int i = 2; i < commandArgs.Length; i++)
                        {
                            storeItems[store].Add(commandArgs[i]);
                        }
                    }
                    else
                    {
                        for (int i = 2; i < commandArgs.Length; i++)
                        {
                            storeItems[store].Add(commandArgs[i]);
                        }
                    }
                }
                else if(command == "Remove")
                {
                    string store = commandArgs[1];

                    storeItems.Remove(store);
                }

                input = Console.ReadLine();
            }

            var sorted = storeItems.OrderByDescending(x => x.Value.Count).ThenByDescending(x => x.Key);

            Console.WriteLine("Stores list:");

            foreach (var store in sorted)
            {
                Console.WriteLine(store.Key);

                foreach (var item in store.Value)
                {
                    Console.WriteLine($"<<{item}>>");
                }
            }
        }
    }
}
