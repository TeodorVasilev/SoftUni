namespace _04._Shopping_Spree
{
	using System;
	using System.Collections.Generic;

	public class Person
	{
		private string name;
		private decimal money;
		private List<Product> bag;

		public Person(string name, decimal money)
		{
			this.Name = name;
			this.Money = money;
			this.bag = new List<Product>();
		}

		public string Name
		{
			get => this.name;

			private set
			{
				if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("Name cannot be empty");
				}

				this.name = value;
			}
		}

		public decimal Money
		{
			get => this.money;

			private set
			{
				if(value < 0)
				{
					throw new ArgumentException("Money cannot be negative");
				}

				this.money = value;
			}
		}

		public void AddProduct(Product product)
		{
			if(product.Price > this.Money)
			{
				Console.WriteLine($"{this.Name} can't afford {product.Name}");
			}
			else
			{
				this.Money -= product.Price;

				bag.Add(product);

				Console.WriteLine($"{this.Name} bought {product.Name}");
			}
		}

		public override string ToString()
		{
			if (bag.Count != 0)
				return $"{this.Name} - {string.Join(", ", this.bag)}";
			else
				return $"{this.Name} - Nothing bought";
		}
	}
}
