namespace SimpleSnake.GameObjects.Foods
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class AsteriskFood : Food
	{
		private const string FoodSymbol = "*";
		private const int FoodPoints = 1;

		public AsteriskFood(Coordinate foodCoordinate) 
			: base(FoodSymbol, FoodPoints, foodCoordinate)
		{
		}
	}
}
