namespace String_Manipulator_Group_2
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            char[] code = Console.ReadLine().ToCharArray();

            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] commandArgs = input.Split();

                string command = commandArgs[0];

                if (command == "Change")
                {
                    char oldLet = char.Parse(commandArgs[1]);
                    char newLet = char.Parse(commandArgs[2]);

                    string temp = new string(code).Replace(oldLet, newLet);

                    code = temp.ToCharArray();

                    Console.WriteLine(new string(code));
                }
                else if(command == "Includes")
                {
                    string sub = commandArgs[1];

                    if(new string(code).Contains(sub))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if(command == "End")
                {
                    string sub = commandArgs[1];

                    if(new string(code).EndsWith(sub))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if(command == "Uppercase")
                {
                    code = code.Select(x => char.ToUpper(x)).ToArray();

                    Console.WriteLine(new string(code));
                }
                else if(command == "FindIndex")
                {
                    char let = char.Parse(commandArgs[1]);

                    int index = code.ToList().IndexOf(let);

                    Console.WriteLine(index);
                }
                else if(command == "Cut")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int length = int.Parse(commandArgs[2]);

                    Console.WriteLine(new string(code).Substring(startIndex, length));
                }

                input = Console.ReadLine();
            }
        }
    }
}
