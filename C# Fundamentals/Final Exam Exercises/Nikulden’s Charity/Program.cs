using System;
using System.Collections.Generic;
using System.Linq;

namespace Nikulden_s_Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] code = Console.ReadLine().ToCharArray();

            string input = Console.ReadLine();

            while (input != "Finish")
            {
                string[] commandArgs = input.Split();
                string command = commandArgs[0];

                if(command == "Replace")
                {
                    char current = char.Parse(commandArgs[1]);
                    char newLet = char.Parse(commandArgs[2]);

                    string temp = new string(code);

                    temp = temp.Replace(current, newLet);

                    Console.WriteLine(temp);

                    code = temp.ToCharArray();
                }
                else if(command == "Make")
                {
                    string caseType = commandArgs[1];

                    if(caseType == "Upper")
                    {
                        code = code.Select(x => char.ToUpper(x)).ToArray();

                        Console.WriteLine(new string(code));
                    }
                    else if(caseType == "Lower")
                    {
                        code = code.Select(x => char.ToLower(x)).ToArray();

                        Console.WriteLine(new string(code));
                    }
                }
                else if(command == "Check")
                {
                    string sub = commandArgs[1];
                    string temp = new string(code);

                    if(temp.Contains(sub))
                    {
                        Console.WriteLine($"Message contains {sub}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {sub}");
                    }
                }
                else if(command == "Sum")
                {
                    int start = int.Parse(commandArgs[1]);
                    int end = int.Parse(commandArgs[2]);
                    int sum = 0;

                    if(start >= 0 && start < code.Length
                        && end >= start && end < code.Length)
                    {
                        for (int i = start; i <= end; i++)
                        {
                            sum += code[i];
                        }

                        Console.WriteLine(sum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }
                else if(command == "Cut")
                {
                    int start = int.Parse(commandArgs[1]);
                    int end = int.Parse(commandArgs[2]);

                    if (start >= 0 && start < code.Length
                        && end >= start && end < code.Length)
                    {
                        string temp = new string(code);

                        temp = temp.Remove(start, end - start + 1);

                        Console.WriteLine(temp);

                        code = temp.ToCharArray();
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
