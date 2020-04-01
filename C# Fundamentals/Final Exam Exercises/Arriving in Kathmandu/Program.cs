namespace Arriving_in_Kathmandu
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<name>^[A-Za-z09!@#$?]+)=(?<length>\d+)<<(?<code>.+)";

            string input = Console.ReadLine();

            while (input != "Last note")
            {
                MatchCollection matches = Regex.Matches(input, pattern);

                if (Regex.IsMatch(input, pattern))
                {
                    string name = "";
                    int length = 0;
                    string code = "";

                    foreach (Match match in matches)
                    {
                        name = match.Groups["name"].Value;
                        length = int.Parse(match.Groups["length"].Value);
                        code = match.Groups["code"].Value;
                    }

                    string temp = "";

                    for (int i = 0; i < name.Length; i++)
                    {
                        if (char.IsLetter(name[i]))
                        {
                            temp += name[i];
                        }
                    }

                    name = temp;

                    if (name != "" && length != 0 && length == code.Length)
                    {
                        Console.WriteLine($"Coordinates found! {name} -> {code}");
                    }
                    else
                    {
                        Console.WriteLine("Nothing found!");
                    }
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }


                input = Console.ReadLine();
            }
        }
    }
}
