namespace _07._Vending_Machine
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			double money = 0;
			
			while (input != "Start")
			{
				double coin = double.Parse(input);

				if(coin == 0.1 || coin == 0.2 || coin == 0.5 ||
					coin == 1 || coin == 2)
				{
					money += coin;
				}
				else
				{
					Console.WriteLine($"Cannot accept {coin}");
				}

				input = Console.ReadLine();
			}

			input = Console.ReadLine();

			while (input != "End")
			{
				switch(input)
				{
					case "Nuts":
						if(money < 2)
						{
							Console.WriteLine("Sorry, not enough money");
						}
						else
						{
							money -= 2;
							Console.WriteLine("Purchased nuts");
						}
						break;
					case "Water":
						if (money < 0.7)
						{
							Console.WriteLine("Sorry, not enough money");
						}
						else
						{
							money -= 0.7;
							Console.WriteLine("Purchased water");
						}
						break;
					case "Crisps":
						if (money < 1.5)
						{
							Console.WriteLine("Sorry, not enough money");
						}
						else
						{
							money -= 1.5;
							Console.WriteLine("Purchased crisps");
						}
						break;
					case "Soda":
						if (money < 0.8)
						{
							Console.WriteLine("Sorry, not enough money");
						}
						else
						{
							money -= 0.8;
							Console.WriteLine("Purchased soda");
						}
						break;
					case "Coke":
						if (money < 1)
						{
							Console.WriteLine("Sorry, not enough money");
						}
						else
						{
							money -= 1;
							Console.WriteLine("Purchased coke");
						}
						break;
					default:
						Console.WriteLine("Invalid product");
						break;
				}

				input = Console.ReadLine();
			}

			Console.WriteLine($"Change: {money:f2}");
		}
	}
}
