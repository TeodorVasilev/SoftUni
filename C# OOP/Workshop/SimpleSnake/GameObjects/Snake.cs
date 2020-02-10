namespace SimpleSnake.GameObjects
{
	using SimpleSnake.Constants;
	using SimpleSnake.Enums;
	using SimpleSnake.GameObjects.Foods;
	using System.Collections.Generic;
	using System.Linq;

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

		public void Eat(Food food)
		{
			for (int i = 0; i < food.Points; i++)
			{
				Coordinate newHeadCoordinate = this.GetNewHeadCoordinates();
				this.snakeBody.Add(newHeadCoordinate);
			}
		}

		private void InitializeBody()
		{
			int x = GameConstant.Snake.DefaultX;
			int y = GameConstant.Snake.DefaultY;
			//TODO change increasing of snake lenght to increase tail
			for (int i = 0; i <= GameConstant.Snake.DefaultLength; i++)
			{
				this.snakeBody.Add(new Coordinate(x, y));
				x++;
			}
		}
	}
}
