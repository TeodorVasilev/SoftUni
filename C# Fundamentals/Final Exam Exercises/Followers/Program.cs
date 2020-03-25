namespace Followers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, int> userCounts = new Dictionary<string, int>();

            int followersCnt = 1;

            while (input != "Log out")
            {
                string[] commandArgs = input.Split(": ");

                string command = commandArgs[0];

                if(command == "New follower")
                {
                    string user = commandArgs[1];

                    if(!userCounts.ContainsKey(user))
                    {
                        userCounts.Add(user, 0);

                        followersCnt++;
                    }
                }
                else if(command == "Like")
                {
                    string user = commandArgs[1];
                    int likeCnt = int.Parse(commandArgs[2]);

                    if (!userCounts.ContainsKey(user))
                    {
                        userCounts.Add(user, likeCnt);

                        followersCnt++;
                    }
                    else
                    {
                        userCounts[user] += likeCnt;
                    }
                }
                else if(command == "Comment")
                {
                    string user = commandArgs[1];

                    if (!userCounts.ContainsKey(user))
                    {
                        userCounts.Add(user, 1);

                        followersCnt++;
                    }
                    else
                    {
                        userCounts[user] += 1;
                    }
                }
                else if(command == "Blocked")
                {
                    string user = commandArgs[1];

                    if (!userCounts.ContainsKey(user))
                    {
                        Console.WriteLine($"{user} doesn't exist.");
                    }
                    else
                    {
                        userCounts.Remove(user);

                        followersCnt--;
                    }
                }

                input = Console.ReadLine();
            }

            var sorted = userCounts.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            Console.WriteLine($"{followersCnt} followers");

            foreach (var kvp in sorted)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
