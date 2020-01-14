using System;
using System.Collections.Generic;

namespace _05._Pizza_Calories
{
	public class Program
	{
		static void Main(string[] args)
		{
			try
			{
				string input = Console.ReadLine();

				string pizzaName = "";

				Pizza pizza = null;
				Dough dough = null;

				List<Topping> toppings = new List<Topping>();

				while (input != "END")
				{
					string[] pizzaArgs = input.Split();
					
					if (pizzaArgs[0] == "Dough")
					{
						string flourType = pizzaArgs[1];
						string bakingTechnique = pizzaArgs[2];
						double weight = double.Parse(pizzaArgs[3]);

						dough = new Dough(flourType, bakingTechnique, weight);

						pizza = new Pizza(pizzaName, dough);
					}
					else if(pizzaArgs[0] == "Topping")
					{
						string toppingType = pizzaArgs[1];
						double toppingWeight = double.Parse(pizzaArgs[2]);

						Topping topping = new Topping(toppingType, toppingWeight);

						toppings.Add(topping);
					}
					else if(pizzaArgs[0] == "Pizza")
					{
						pizzaName = pizzaArgs[1];
					}
					
					input = Console.ReadLine();
				}

				for (int i = 0; i < toppings.Count; i++)
				{
					pizza.AddTopping(toppings[i]);
				}

				Console.WriteLine(pizza);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
