
namespace SimpleSnake.Core
{
    using SimpleSnake.Enums;
    using SimpleSnake.GameObjects;
    using SimpleSnake.GameObjects.Foods;
    using System;
	using System.Collections.Generic;
	using System.Text;
    using System.Threading;

    public class Engine
	{
		private const string SnakeSymbol = "o";//"\u25cf";

		private DrawManager drawManager;
		private Snake snake;
		private Food food;

		public Engine(DrawManager drawManager, Snake snake)
		{
			this.drawManager = drawManager;
			this.snake = snake;
		}

		public void Run()
		{
			while (true)
			{
				if(Console.KeyAvailable)
				{
					this.SetCorrectDirection(Console.ReadKey());
				}

				this.food = new AsteriskFood(new Coordinate(20, 20));

				this.drawManager.Draw(food.Symbol, new List<Coordinate> { food.FoodCoordinate });

				this.drawManager.Draw(SnakeSymbol, this.snake.Body);

				this.snake.Move();

				this.drawManager.UndoDraw();

				Thread.Sleep(200);
			}
		}

		private bool HasFoodCollision()
		{
			int snakeHeadCoordinateX = this.snake.Head.CoordinateX;
			int snakeHeadCoordinateY = this.snake.Head.CoordinateY;

			int foodCoordinateX = this.food.FoodCoordinate.CoordinateX;
			int foodCoordinateY = this.food.FoodCoordinate.CoordinateY;
		}

		private void SetCorrectDirection(ConsoleKeyInfo consoleKeyInfo)
		{
			Direction currentSnakeDirection = this.snake.Direction;

			switch (consoleKeyInfo.Key)
			{
                case ConsoleKey.DownArrow:
					if(currentSnakeDirection != Direction.Up)
					{
						currentSnakeDirection = Direction.Down;
					}
                    break;
				case ConsoleKey.LeftArrow:
					if(currentSnakeDirection != Direction.Right)
					{
						currentSnakeDirection = Direction.Left;
					}
					break;
				case ConsoleKey.RightArrow:
					if(currentSnakeDirection != Direction.Left)
					{
						currentSnakeDirection = Direction.Right;
					}
					break;
                case ConsoleKey.UpArrow:
					if(currentSnakeDirection != Direction.Down)
					{
						currentSnakeDirection = Direction.Up;
					}
                    break;
			}

			this.snake.Direction = currentSnakeDirection;
		}
	}
}
