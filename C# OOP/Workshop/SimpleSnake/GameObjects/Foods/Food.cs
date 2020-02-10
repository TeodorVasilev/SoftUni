namespace SimpleSnake.GameObjects.Foods
{
	public abstract class Food
	{
		public Food(string symbol, int points, Coordinate foodCoordinate)
		{
			this.Symbol = symbol;
			this.Points = points;
			this.FoodCoordinate = foodCoordinate;
		}

		public string Symbol { get; set; }

		public int Points { get; set; }

		public Coordinate FoodCoordinate { get; set; }
	}
}
