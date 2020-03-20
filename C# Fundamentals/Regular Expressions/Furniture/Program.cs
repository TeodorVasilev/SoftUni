namespace Furniture
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> items = new List<string>();

            double totalMoneySpent = 0;

            while (input != "Purchase")
            {
                string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+(.\d+)?)!(?<quant>\d+)";

                MatchCollection matches = Regex.Matches(input, pattern);

                foreach (Match match in matches)
                {
                    string name = match.Groups["name"].Value;
                    string priceString = match.Groups["price"].Value;
                    string quantityString = match.Groups["quant"].Value;

                    double price = double.Parse(priceString);
                    int quantity = int.Parse(quantityString);
                    totalMoneySpent += price * quantity;

                    items.Add(name);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture: ");

            foreach (var kvp in items)
            {
                Console.WriteLine(kvp);
            }

            Console.WriteLine($"Total money spend: {totalMoneySpent:f2}");
        }
    }
}
