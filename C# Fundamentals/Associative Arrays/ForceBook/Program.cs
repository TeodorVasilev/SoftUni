namespace ForceBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, string> userSide = new Dictionary<string, string>();

            while (input != "Lumpawaroo")
            {
                if(input.Contains("|"))
                {
                    string[] sideArgs = input.Split(" | ");
                    
                    string side = sideArgs[0];
                    string user = sideArgs[1];

                    if(!userSide.ContainsKey(user))
                    {
                        userSide.Add(user, side);
                    }
                }
                else if(input.Contains("->"))
                {
                    string[] userArgs = input.Split(" -> ");

                    string user = userArgs[0];
                    string side = userArgs[1];

                    if(!userSide.ContainsKey(user))
                    {
                        userSide.Add(user, side);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                    else
                    {
                        userSide[user] = side;
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                }

                input = Console.ReadLine();
            }

            var sorted = userSide.GroupBy(x => x.Value).OrderByDescending(x => x.Count()).ThenBy(x => x.Key);

            foreach (var side in sorted)
            {
                Console.WriteLine($"Side: { side.Key}, Members: {side.Count()} ");

                foreach (var user in side.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"! {user.Key}");
                }
            }
        }
    }
}
