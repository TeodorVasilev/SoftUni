namespace Restaurant
{
	public class Coffee : HotBeverage
	{
		private const double coffeeMilliliters = 50;
		private const decimal coffeePrice = 3.50M;

		public Coffee(string name, double caffeine)
			: base(name, coffeePrice, coffeeMilliliters)
		{
			this.Caffeine = caffeine;
		}

		public double Caffeine { get; set; }
	}
}
