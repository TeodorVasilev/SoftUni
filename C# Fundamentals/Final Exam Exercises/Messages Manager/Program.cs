namespace Messages_Manager
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int messagesPerUser = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            Dictionary<string, int> userSent = new Dictionary<string, int>();
            Dictionary<string, int> userReceived = new Dictionary<string, int>();

            while (input != "Statistics")
            {
                string[] commandArgs = input.Split('=');

                string command = commandArgs[0];

                if (command == "Add")
                {
                    string user = commandArgs[1];
                    int sent = int.Parse(commandArgs[2]);
                    int received = int.Parse(commandArgs[3]);

                    if(!userSent.ContainsKey(user))
                    {
                        userSent.Add(user, sent);
                        userReceived.Add(user, received);
                    }
                }
                else if(command == "Message")
                {
                    string sender = commandArgs[1];
                    string receiver = commandArgs[2];

                    if(userSent.ContainsKey(sender) && userSent.ContainsKey(receiver))
                    {
                        userSent[sender]++;
                        userReceived[receiver]++;

                        if(userSent[sender] + userReceived[sender] >= messagesPerUser)
                        {
                            userSent.Remove(sender);
                            userReceived.Remove(sender);

                            Console.WriteLine($"{sender} reached the capacity!");
                        }
                        
                        if(userReceived[receiver] + userSent[receiver] >= messagesPerUser)
                        {
                            userSent.Remove(receiver);
                            userReceived.Remove(receiver);

                            Console.WriteLine($"{receiver} reached the capacity!");
                        }
                    }
                }
                else if(command == "Empty")
                {
                    string user = commandArgs[1];

                    if(user == "All")
                    {
                        userSent.Clear();
                        userReceived.Clear();
                    }
                    else
                    {
                        userReceived.Remove(user);
                        userSent.Remove(user);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Users count: {userSent.Count}");

            var sorted = userReceived.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            foreach (var kvp in sorted)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value + userSent[kvp.Key]}");
            }
        }
    }
}
