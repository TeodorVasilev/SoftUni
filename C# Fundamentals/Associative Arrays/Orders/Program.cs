namespace Orders
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, double> productPrice = new Dictionary<string, double>();
            Dictionary<string, int> productCnt = new Dictionary<string, int>();

            while (input != "buy")
            {
                string[] itemArgs = input.Split();
                string product = itemArgs[0];
                double price = double.Parse(itemArgs[1]);
                int quantity = int.Parse(itemArgs[2]);

                if(!productCnt.ContainsKey(product))
                {
                    productCnt[product] = 0;
                }

                productCnt[product] += quantity;

                if(!productPrice.ContainsKey(product))
                {
                    productPrice[product] = 0;
                }

                productPrice[product] = price;

                input = Console.ReadLine();
            }

            foreach (var kvp in productPrice)
            {
                string product = kvp.Key;
                double price = kvp.Value;
                int quantity = productCnt[product];

                Console.WriteLine($"{product} -> {price * quantity:f2}");
            }
        }
    }
}
