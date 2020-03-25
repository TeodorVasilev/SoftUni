namespace Username
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            char[] username = Console.ReadLine().ToCharArray();

            string input = Console.ReadLine();

            while (input != "Sign up")
            {
                string[] commandArgs = input.Split();

                string command = commandArgs[0];

                if (command == "Case")
                {
                    if(commandArgs[1] == "lower")
                    {
                        username = username.Select(x => char.ToLower(x)).ToArray();

                        Console.WriteLine(new string(username));
                    }
                    else if(commandArgs[1] == "upper")
                    {
                        username = username.Select(x => char.ToUpper(x)).ToArray();

                        Console.WriteLine(new string(username));
                    }
                }
                else if (command == "Reverse")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);

                    int count = endIndex - startIndex;

                    if(startIndex > 0 && startIndex < username.Length
                        && endIndex > startIndex && endIndex < username.Length)
                    {
                        char[] sub = new string(username).Substring(startIndex, count + 1).ToCharArray();

                        Console.WriteLine(string.Join("", sub.Reverse()));
                    }

                }
                else if (command == "Cut")
                {
                    string sub = commandArgs[1];

                    if(!new string(username).Contains(sub))
                    {
                        Console.WriteLine($"The word {new string(username)} doesn't contain {sub}.");
                    }
                    else
                    {
                        username = new string(username).Replace(sub, "").ToCharArray();

                        Console.WriteLine(new string(username));
                    }
                }
                else if (command == "Replace")
                {
                    char newLet = char.Parse(commandArgs[1]);

                    string temp = new string(username).Replace(newLet, '*');

                    username = temp.ToCharArray();

                    Console.WriteLine(new string(username));
                }
                else if (command == "Check")
                {
                    char newLet = char.Parse(commandArgs[1]);

                    if (username.Contains(newLet))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {newLet}.");
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
