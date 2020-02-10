namespace SimpleSnake.GameObjects.Foods
{
	using SimpleSnake.Constants;

	public class HashFood : Food
	{
		public HashFood(Coordinate foodCoordinate) 
			: base(GameConstant.Food.HashSymbol, GameConstant.Food.HashPoints, foodCoordinate)
		{
		}
	}
}
