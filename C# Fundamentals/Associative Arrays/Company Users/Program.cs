namespace Company_Users
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<string, List<string>> companyUsers = new SortedDictionary<string, List<string>>();
                 
            while (input != "End")
            {
                string[] companyArgs = input.Split(" -> ");

                string name = companyArgs[0];
                string id = companyArgs[1];

                if(!companyUsers.ContainsKey(name))
                {
                    companyUsers[name] = new List<string>();
                    companyUsers[name].Add(id);
                }
                else
                {
                    if(!companyUsers[name].Contains(id))
                    {
                        companyUsers[name].Add(id);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in companyUsers)
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
