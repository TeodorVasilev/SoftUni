namespace Password
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string pattern = @"^(.+)>(?<num>\d{3})\|(?<low>[a-z]{3})\|(?<up>[A-Z]{3})\|(?<symb>[^<>]{3})<(\1)$";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                MatchCollection matches = Regex.Matches(input, pattern);

                string numbers = "";
                string lower = "";
                string upper = "";
                string symb = "";

                foreach (Match match in matches)
                {
                    numbers = match.Groups["num"].Value;
                    lower = match.Groups["low"].Value;
                    upper = match.Groups["up"].Value;
                    symb = match.Groups["symb"].Value;
                }

                if(numbers != "" && lower != "" && upper != "" && symb != "")
                {
                    Console.WriteLine($"Password: {numbers}{lower}{upper}{symb}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
