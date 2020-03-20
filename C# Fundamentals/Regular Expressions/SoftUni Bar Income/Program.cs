namespace SoftUni_Bar_Income
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"^%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";

            double income = 0;

            while (input != "end of shift")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);
                    string customer = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;

                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    double money = price * count;

                    Console.WriteLine($"{customer}: {product} - {money:F2}");
                    income += money;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {income:F2}");
        }
    }
}
