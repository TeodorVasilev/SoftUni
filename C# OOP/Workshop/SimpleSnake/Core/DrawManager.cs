
namespace SimpleSnake.Core
{
    using System;
	using System.Collections.Generic;
    using System.Linq;
    using System.Text;
	using SimpleSnake.GameObjects;

	public class DrawManager
	{
		private const string SnakeSymbol = "o";
		private List<Coordinate> snakeBodyElements;

		public DrawManager()
		{
			this.snakeBodyElements = new List<Coordinate>();
		}

		public void Draw(string symbol, IEnumerable<Coordinate> coordinates)
		{
			foreach (var coordinate in coordinates)
			{
				if(symbol == SnakeSymbol)
				{
					Console.SetCursorPosition(coordinate.CoordinateX, coordinate.CoordinateY);
					Console.Write(symbol);
					snakeBodyElements.Add(coordinate);
				}
				else
				{
					Console.SetCursorPosition(coordinate.CoordinateX, coordinate.CoordinateY);
					Console.Write(symbol);
				}
			}
		}

		public void UndoDraw()
		{
			Coordinate lastElement = this.snakeBodyElements.First();

			Console.SetCursorPosition(lastElement.CoordinateX, lastElement.CoordinateY);
			Console.Write(" ");
			this.snakeBodyElements.Clear();
		}
	}
}
