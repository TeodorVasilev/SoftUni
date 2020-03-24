namespace Inbox_Manager
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int userCount = 0;

            Dictionary<string, List<string>> userMails = new Dictionary<string, List<string>>();

            while (input != "Statistics")
            {
                string[] commandArgs = input.Split("->");

                string command = commandArgs[0];

                if(command == "Add")
                {
                    string username = commandArgs[1];

                    if (!userMails.ContainsKey(username))
                    {
                        userMails.Add(username, new List<string>());
                        userCount++;
                    }
                    else
                    {
                        Console.WriteLine($"{username} is already registered");
                    }
                }
                else if(command == "Send")
                {
                    string username = commandArgs[1];
                    string email = commandArgs[2];

                    if(userMails.ContainsKey(username))
                    {
                        userMails[username].Add(email);
                    }
                }
                else if(command == "Delete")
                {
                    string username = commandArgs[1];

                    if(userMails.ContainsKey(username))
                    {
                        userMails.Remove(username);

                        userCount--;
                    }
                    else
                    {
                        Console.WriteLine($"{username} not found!");
                    }
                }

                input = Console.ReadLine();
            }

            var sorted = userMails.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key);

            Console.WriteLine($"Users count: {userCount}");

            foreach (var kvp in sorted)
            {
                Console.WriteLine(kvp.Key);

                foreach (var email in kvp.Value)
                {
                    Console.WriteLine($" - {email}");
                }
            }
        }
    }
}
