namespace Email_Validator
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            char[] email = Console.ReadLine().ToCharArray();

            string input = Console.ReadLine();

            while (input != "Complete")
            {
                string[] commandArgs = input.Split();

                string command = commandArgs[0];

                if(command == "Make")
                {
                    if(commandArgs[1] == "Upper")
                    {
                        email = email.Select(x => char.ToUpper(x)).ToArray();

                        Console.WriteLine(new string(email));
                    }
                    else if(commandArgs[1] == "Lower")
                    {
                        email = email.Select(x => char.ToLower(x)).ToArray();

                        Console.WriteLine(new string(email));
                    }
                }
                else if(command == "GetDomain")
                {
                    int count = int.Parse(commandArgs[1]);

                    Console.WriteLine(new string(email).Substring(email.Length - count));
                }
                else if(command == "GetUsername")
                {
                    bool isValid = false;

                    int index = 0;
                    
                    for (int i = 0; i < email.Length; i++)
                    {
                        if(email[i] == '@')
                        {
                            isValid = true;
                            index = i;
                        }
                    }

                    if(isValid)
                    {
                        Console.WriteLine(new string(email).Substring(0, index));
                    }
                    else
                    {
                        Console.WriteLine($"The email {new string(email)} doesn't contain the @ symbol.");
                    }
                }
                else if(command == "Replace")
                {
                    char newLet = char.Parse(commandArgs[1]);

                    string temp = new string(email);

                    temp = temp.Replace(newLet, '-');

                    email = temp.ToCharArray();

                    Console.WriteLine(new string(email));
                }
                else if(command == "Encrypt")
                {
                    for (int i = 0; i < email.Length; i++)
                    {
                        int value = email[i];

                        Console.Write(value + " ");
                    }

                    Console.WriteLine();
                }

                input = Console.ReadLine();
            }
        }
    }
}
