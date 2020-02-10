namespace SimpleSnake.Constants
{
	public static class GameConstant
	{
		public static class Snake
		{
			public static readonly string Symbol = "o";
			public static readonly int DefaultLength = 6;
			public static readonly int DefaultX = 8;
			public static readonly int DefaultY = 7;
		}

		public static class Food
		{
			public static readonly string AsteriskSymbol = "*";
			public static readonly string DollarSymbol = "$";
			public static readonly string HashSymbol = "#";

			public static readonly int AsteriskPoints = 1;
			public static readonly int DollarPoints = 2;
			public static readonly int HashPoints = 3;
		}

		public static class Board
		{
			public static readonly int DefaultBoardWidth = 120;
			public static readonly int DefaultBoardHeight = 40;

			public static readonly string DefaultBoardSymbol = "\u25a0";
		}

		public static class Player
		{
			public static readonly int PlayerScoreOffsetX = 125;
			public static readonly int PlayerScoreOffsetY = 5;
		}

		public static class Config
		{
			public static readonly int EndMessageX = 45;
			public static readonly int EndMessageY = 20;
		}
	}
}
