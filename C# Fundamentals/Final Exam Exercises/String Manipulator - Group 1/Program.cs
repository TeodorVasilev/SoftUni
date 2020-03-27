namespace String_Manipulator___Group_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine().ToCharArray();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] commandArgs = input.Split();

                string command = commandArgs[0];

                if(command == "Translate")
                {
                    char oldLet = char.Parse(commandArgs[1]);
                    char newLet = char.Parse(commandArgs[2]);

                    text = new string(text).Replace(oldLet, newLet).ToCharArray();

                    Console.WriteLine(new string(text));
                }
                else if(command == "Includes")
                {
                    string sub = commandArgs[1];

                    if(new string(text).Contains(sub))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if(command == "Lowercase")
                {
                    text = text.Select(x => char.ToLower(x)).ToArray();

                    Console.WriteLine(new string(text));
                }
                else if(command == "Start")
                {
                    string sub = commandArgs[1];

                    if(new string(text).StartsWith(sub))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if(command == "FindIndex")
                {
                    char let = char.Parse(commandArgs[1]);

                    int index = text.ToList().LastIndexOf(let);

                    Console.WriteLine(index);
                }
                else if(command == "Remove")
                {
                    int index = int.Parse(commandArgs[1]);
                    int count = int.Parse(commandArgs[2]);

                    List<char> temp = text.ToList();

                    temp.RemoveRange(index, count);

                    text = temp.ToArray();

                    Console.WriteLine(new string(text));
                }

                input = Console.ReadLine();
            }
        }
    }
}
