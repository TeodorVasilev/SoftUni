namespace _05._Pizza_Calories
{
	using System;
	using System.Collections.Generic;

	public class Pizza
	{
		private const int numberOfToppings = 10;

		private string name;
		private Dough dough;
		private List<Topping> toppings;

		public Pizza(string name, Dough dough)
		{
			this.Name = name;
			this.dough = dough;
			this.toppings = new List<Topping>();
		}

		public string Name
		{
			get => this.name;

			private set
			{
				if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length > 15)
				{
					throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
				}

				this.name = value;
			}
		}

		public void AddTopping(Topping topping)
		{
			if(this.toppings.Count < 10)
			{
				this.toppings.Add(topping);
			}
			else
			{
				throw new InvalidOperationException("Number of toppings should be in range [0..10].");
			}
		}

		private double CalculateToppingsCalories()
		{
			double total = 0;

			foreach (var topping in toppings)
			{
				total += topping.CalculateCalories();
			}

			return total;
		}

		private double GetCalories()
		{
			return this.dough.CalculateCalories() + CalculateToppingsCalories();
		}

		public override string ToString()
		{
			return $"{this.Name} - {this.GetCalories():f2} Calories.";
		}
	}
}
