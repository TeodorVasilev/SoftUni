namespace Registration
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string pattern = @"([U][$])(?<name>[A-Z][a-z]{2,})\1([P][@][$])(?<pass>[A-Za-z]{5,}\d+)\2";

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                MatchCollection matches = Regex.Matches(input, pattern);

                string username = "";
                string password = "";

                foreach (Match match in matches)
                {
                    username = match.Groups["name"].Value;
                    password = match.Groups["pass"].Value;
                }

                if (username != "" && password != "")
                {
                    Console.WriteLine("Registration was successful");

                    Console.WriteLine($"Username: {username}, Password: {password}");

                    count++;
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }

            Console.WriteLine($"Successful registrations: {count}");
        }
    }
}
