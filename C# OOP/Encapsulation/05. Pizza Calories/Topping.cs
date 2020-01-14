namespace _05._Pizza_Calories
{
	using System;
	using System.Collections.Generic;

	public class Topping
	{
		private const double caloriesPerGram = 2;

		private string toppingType;
		private double weight;
		private Dictionary<string, double> toppingTypeModifiers;

		public Topping(string toppingType, double weight)
		{
			this.toppingTypeModifiers = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase);
			this.SeedToppingTypes();
			this.ToppingType = toppingType;
			this.Weight = weight;
		}

		public string ToppingType
		{
			get => this.toppingType;

			private set
			{
				if (!this.toppingTypeModifiers.ContainsKey(value))
				{
					throw new ArgumentException($"Cannot place {value.ToString()} on top of your pizza.");
				}

				this.toppingType = value;
			}
		}

		public double Weight
		{
			get => this.weight;

			private set
			{
				if(value < 1 || value > 50)
				{
					throw new ArgumentException($"{this.ToppingType} weight should be in the range [1..50].");
				}

				this.weight = value;
			}
		}
		
		public double CalculateCalories()
		{
			return ((caloriesPerGram * this.Weight) * this.toppingTypeModifiers[this.ToppingType]);
		}

		private void SeedToppingTypes()
		{
			this.toppingTypeModifiers.Add("Meat", 1.2);
			this.toppingTypeModifiers.Add("Veggies", 0.8);
			this.toppingTypeModifiers.Add("Cheese", 1.1);
			this.toppingTypeModifiers.Add("Sauce", 0.9);
		}
	}
}
