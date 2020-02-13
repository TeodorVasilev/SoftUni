namespace House_Party
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> guestNames = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine().Split();

                string guestName = inputArgs[0];

                if (inputArgs.Length == 3)
                {
                    if(!guestNames.Contains(guestName))
                    {
                        guestNames.Add(guestName);
                    }
                    else
                    {
                        Console.WriteLine($"{guestName} is already in the list!");
                    }
                }
                else if(inputArgs.Length == 4)
                {
                    if(!guestNames.Contains(guestName))
                    {
                        Console.WriteLine($"{guestName} is not in the list!");
                    }
                    else
                    {
                        guestNames.Remove(guestName);
                    }
                }
            }

            guestNames.ForEach(Console.WriteLine);
        }
    }
}
