using System;
using System.Collections.Generic;
using System.Linq;

namespace Shoping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine().Split('!').ToList();

            string input = Console.ReadLine();

            while (input != "Go Shopping!")
            {
                string[] commandArgs = input.Split();

                string command = commandArgs[0];

                if (command == "Unnecessary")
                {
                    string item = commandArgs[1];

                    if (groceries.Contains(item))
                        groceries.Remove(item);
                }
                else if (command == "Urgent")
                {
                    string item = commandArgs[1];

                    if (!groceries.Contains(item))
                        groceries.Insert(0, item);
                }
                else if (command == "Rearrange")
                {
                    string item = commandArgs[1];

                    if(groceries.Contains(item))
                    {
                        int index = groceries.IndexOf(item);

                        groceries.RemoveAt(index);
                        groceries.Add(item);
                    }
                }
                else if (command == "Correct")
                {
                    string oldItem = commandArgs[1];
                    string newItem = commandArgs[2];

                    if (groceries.Contains(oldItem))
                    {
                        int index = groceries.IndexOf(oldItem);
                        groceries[index] = newItem;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}
