namespace Warrior_s_Quest
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            char[] code = Console.ReadLine().ToCharArray();

            string input = Console.ReadLine();
    
            while (input != "For Azeroth")
            {
                string[] commandArgs = input.Split();

                string command = commandArgs[0];

                if(command == "GladiatorStance")
                {
                    code = code.Select(x => char.ToUpper(x)).ToArray();
                    Console.WriteLine(code);
                }
                else if(command == "DefensiveStance")
                {
                    code = code.Select(x => char.ToLower(x)).ToArray();
                    Console.WriteLine(code);
                }
                else if(command == "Dispel")
                {
                    int index = int.Parse(commandArgs[1]);
                    char letter = char.Parse(commandArgs[2]);

                    if(index < 0 || index > code.Length - 1)
                    {
                        Console.WriteLine("Dispel too weak.");
                    }
                    else
                    {
                        code[index] = letter;
                        Console.WriteLine("Success!");
                    }
                }
                else if(command == "Target")
                {
                    if(commandArgs[1] == "Change")
                    {
                        string sub = commandArgs[2];
                        string secondSub = commandArgs[3];

                        string codeToStr = new string(code);

                        codeToStr = codeToStr.Replace(sub, secondSub);

                        Console.WriteLine(codeToStr);

                        code = codeToStr.ToCharArray();

                    }
                    else if(commandArgs[1] == "Remove")
                    {
                        string sub = commandArgs[2];

                        string codeToStr = new string(code);

                        codeToStr = codeToStr.Replace(sub, "");

                        Console.WriteLine(codeToStr);

                        code = codeToStr.ToCharArray();
                    }
                }
                else
                {
                    Console.WriteLine("Command doesn't exist!");
                }

                input = Console.ReadLine();
            }
        }
    }
}
