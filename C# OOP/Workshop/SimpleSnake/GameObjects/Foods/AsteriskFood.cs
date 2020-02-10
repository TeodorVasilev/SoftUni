namespace SimpleSnake.GameObjects.Foods
{
	using SimpleSnake.Constants;

	public class AsteriskFood : Food
	{
		public AsteriskFood(Coordinate foodCoordinate) 
			: base(GameConstant.Food.AsteriskSymbol, GameConstant.Food.AsteriskPoints, foodCoordinate)
		{
		}
	}
}
