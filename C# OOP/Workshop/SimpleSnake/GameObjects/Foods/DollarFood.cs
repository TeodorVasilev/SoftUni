namespace SimpleSnake.GameObjects.Foods
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class DollarFood : Food
	{
		private const string FoodSymbol = "$";
		private const int FoodPoints = 2;

		public DollarFood(Coordinate foodCoordinate) 
			: base(FoodSymbol, FoodPoints, foodCoordinate)
		{
		}
	}
}
