namespace SimpleSnake.GameObjects
{
    using SimpleSnake.Enums;
    using System;
	using System.Collections.Generic;
    using System.Linq;
    using System.Text;

	public class Snake
	{
		private const int DefaultLenth = 6;
		private const int DefaultX = 8;
		private const int DefaultY = 7;

		private List<Coordinate> snakeBody;

		public Snake()
		{
			this.snakeBody = new List<Coordinate>();
			this.InitializeBody();
			this.Direction = Direction.Right;
		}

		public IReadOnlyCollection<Coordinate> Body => this.snakeBody.AsReadOnly();

		public Direction Direction { get; set; }

		public Coordinate Head => this.snakeBody.Last();

		public void Move()
		{
			Coordinate newHead = this.GetNewHeadCoordinates(); 
			this.snakeBody.Add(newHead);
			this.snakeBody.RemoveAt(0);
		}

		private Coordinate GetNewHeadCoordinates()
		{
			Coordinate newHeadCoordinate = new Coordinate(this.Head.CoordinateX, this.Head.CoordinateY);

			switch (this.Direction)
			{
				case Direction.Right:
					newHeadCoordinate.CoordinateX++;
					break;
				case Direction.Left:
					newHeadCoordinate.CoordinateX--;
					break;
				case Direction.Down:
					newHeadCoordinate.CoordinateY++;
					break;
				case Direction.Up:
					newHeadCoordinate.CoordinateY--;
					break;
			}

			return newHeadCoordinate;
		}

		private void InitializeBody()
		{
			int x = DefaultX;
			int y = DefaultY;

			for (int i = 0; i <= DefaultLenth; i++)
			{
				this.snakeBody.Add(new Coordinate(x, y));
				x++;
			}
		}
	}
}
