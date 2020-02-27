namespace Contact_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> contacts = Console.ReadLine().Split().ToList();

            string input = Console.ReadLine();

            while (true)
            {
                string[] commandArgs = input.Split();

                string command = commandArgs[0];

                if(command == "Add")
                {
                    string contact = commandArgs[1];
                    int index = int.Parse(commandArgs[2]);

                    if (!contacts.Contains(contact))
                    {
                        contacts.Add(contact);
                    }
                    else
                    {
                        if (index >= 0 && index < contacts.Count)
                        {
                            contacts.Insert(index, contact);
                        }
                    }
                }
                else if(command == "Remove")
                {
                    int index = int.Parse(commandArgs[1]);

                    if (index >= 0 && index < contacts.Count)
                    {
                        contacts.RemoveAt(index);
                    }
                }
                else if(command == "Export")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int count = int.Parse(commandArgs[2]);

                    if (startIndex >= 0 && startIndex < contacts.Count)
                    {
                        if(startIndex + count > contacts.Count)
                        {
                            for (int i = startIndex; i < contacts.Count; i++)
                            {
                                Console.Write(contacts[i] + " ");
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            for (int i = startIndex; i < startIndex + count; i++)
                            {
                                Console.Write(contacts[i] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
                else if(command == "Print")
                {
                    if(commandArgs[1] == "Normal")
                    {
                        Console.WriteLine($"Contacts: {string.Join(" ", contacts)}");
                        return;
                    }
                    else if(commandArgs[1] == "Reversed")
                    {
                        contacts.Reverse();

                        Console.WriteLine($"Contacts: {string.Join(" ", contacts)}");
                        return;
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
