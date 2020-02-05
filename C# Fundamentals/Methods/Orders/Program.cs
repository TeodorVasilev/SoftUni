namespace Orders
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			string product = Console.ReadLine();
			int quantity = int.Parse(Console.ReadLine());

			double result = GetSum(product, quantity);

			Console.WriteLine($"{result:f2}");
		}

		static double GetSum(string product, int quantity)
		{
			double productPrice = 0;

			switch (product)
			{
				case "coffee":
					productPrice = 1.50;
					break;
				case "water":
					productPrice = 1;
					break;
				case "coke":
					productPrice = 1.40;
					break;
				case "snacks":
					productPrice = 2;
					break;
			}

			return productPrice * quantity;
		}
	}
}
