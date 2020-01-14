namespace _04._Shopping_Spree
{
	using System;

	public class Product
	{
		private string name;
		private decimal price;

		public Product(string name, decimal price)
		{
			this.Name = name;
			this.Price = price;
		}

		public string Name
		{
			get => this.name;

			private set
			{
				if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("Name cannot be empty");
				}

				this.name = value;
			}
		}

		public decimal Price
		{
			get => this.price;

			private set
			{
				if (value < 0)
				{
					throw new ArgumentException("Money cannot be negative");
				}

				this.price = value;
			}
		}

		public override string ToString()
		{
			return $"{this.Name}";
		}
	}
}
