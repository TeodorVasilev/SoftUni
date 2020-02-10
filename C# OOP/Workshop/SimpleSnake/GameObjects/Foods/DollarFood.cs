namespace SimpleSnake.GameObjects.Foods
{
	using SimpleSnake.Constants;

	public class DollarFood : Food
	{
		public DollarFood(Coordinate foodCoordinate) 
			: base(GameConstant.Food.DollarSymbol, GameConstant.Food.DollarPoints, foodCoordinate)
		{
		}
	}
}
