namespace SimpleSnake.GameObjects.Foods
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class HashFood : Food
	{
		private const string FoodSymbol = "#";
		private const int FoodPoints = 3;

		public HashFood(Coordinate foodCoordinate) 
			: base(FoodSymbol, FoodPoints, foodCoordinate)
		{
		}
	}
}
