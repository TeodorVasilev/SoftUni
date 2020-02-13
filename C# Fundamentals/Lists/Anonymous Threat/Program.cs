namespace Anonymous_Threat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split().ToList();

            string input = Console.ReadLine();

            while (input != "3:1")
            {
                string[] inputArgs = input.Split();

                if(inputArgs[0] == "merge")
                {
                    int startIndex = int.Parse(inputArgs[1]);
                    int endIndex = int.Parse(inputArgs[2]);

                    if(startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    
                    if(endIndex > data.Count - 1)
                    {
                        endIndex = data.Count - 1;
                    }


                }
                else if(inputArgs[0] == "divide")
                {
                    int index = int.Parse(inputArgs[1]);
                    int partitions = int.Parse(inputArgs[2]);
                }
            }
        }
    }
}
