namespace SimpleSnake.Core
{
    using SimpleSnake.Constants;
    using SimpleSnake.Enums;
    using SimpleSnake.Factories;
    using SimpleSnake.GameObjects;
    using SimpleSnake.GameObjects.Foods;
    using System;
	using System.Collections.Generic;
    using System.Threading;

    public class Engine
	{
		private DrawManager drawManager;
		private Snake snake;
		private Food food;
		private Coordinate boardCoordinate;
		private int gameScore;

		public Engine(DrawManager drawManager, Snake snake, Coordinate boardCoordinate)
		{
			this.drawManager = drawManager;
			this.snake = snake;
			this.boardCoordinate = boardCoordinate;
			this.InitializeFood();
			this.InitializeBorders();
		}

		public void Run()
		{
			while (true)
			{
				this.PlayerInfo();

				if(Console.KeyAvailable)
				{
					this.SetCorrectDirection(Console.ReadKey());
				}

				this.drawManager.Draw(food.Symbol, new List<Coordinate> { food.FoodCoordinate });

				this.drawManager.Draw(GameConstant.Snake.Symbol, this.snake.Body);

				this.snake.Move();

				this.drawManager.UndoDraw();

				if(HasFoodCollision())
				{
					this.snake.Eat(this.food);
					this.gameScore += this.food.Points;
					this.InitializeFood();
				}

				if(HasBorderCollision())
				{
					this.AskPlayerForRestart();
				}

				Thread.Sleep(50);
			}
		}

		private void PlayerInfo()
		{
			int x = GameConstant.Player.PlayerScoreOffsetX;
			int y = GameConstant.Player.PlayerScoreOffsetY;

			Console.SetCursorPosition(x, y);
			Console.Write($"Game Score {this.gameScore}");
		}

		private void AskPlayerForRestart()
		{
			int x = GameConstant.Config.EndMessageX;
			int y = GameConstant.Config.EndMessageY;

			Console.SetCursorPosition(x, y);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Would you like to continue?");

			Console.SetCursorPosition(x+12, y + 1);
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Y/N");

			var input = Console.ReadKey();
			//TODO fix exception when N
			if(input.Key == ConsoleKey.Y)
			{
				Console.Clear();
				StartUp.Main();
			}
			else
			{
				return;
			}
		}

		private bool HasBorderCollision()
		{
			int snakeHeadCoordinateX = this.snake.Head.CoordinateX;
			int snakeHeadCoordinateY = this.snake.Head.CoordinateY;

			int boardCoordinateX = this.boardCoordinate.CoordinateX;
			int boardCoordinateY = this.boardCoordinate.CoordinateY;

			return snakeHeadCoordinateX == boardCoordinateX
				|| snakeHeadCoordinateX == 0
				|| snakeHeadCoordinateY == boardCoordinateY
				|| snakeHeadCoordinateY == 0;
		}

		//TODO fix snake eating borders
		private void InitializeBorders()
		{
			List<Coordinate> allCoordinates = new List<Coordinate>();

			this.InitializeHorizontalBorderCoordinates(0, allCoordinates);
			this.InitializeHorizontalBorderCoordinates(GameConstant.Board.DefaultBoardHeight, allCoordinates);
			this.InitializeVerticalBorderCoordinates(0, allCoordinates);
			this.InitializeVerticalBorderCoordinates(GameConstant.Board.DefaultBoardWidth, allCoordinates);

			this.drawManager.Draw(GameConstant.Board.DefaultBoardSymbol, allCoordinates);
		}

		private void InitializeVerticalBorderCoordinates(int coordinateX, List<Coordinate> allCoordinates)
		{
			for (int coordinateY = 0; coordinateY <= this.boardCoordinate.CoordinateY; coordinateY++)
			{
				allCoordinates.Add(new Coordinate(coordinateX, coordinateY));
			}
		}

		private void InitializeHorizontalBorderCoordinates(int coordinateY, List<Coordinate> allCoordinates)
		{
			for (int coordinateX = 0; coordinateX < this.boardCoordinate.CoordinateX; coordinateX++)
			{
				allCoordinates.Add(new Coordinate(coordinateX, coordinateY));
			}
		}

		private void InitializeFood()
		{
			this.food = FoodFactory.GetRandomFood(this.boardCoordinate.CoordinateX, this.boardCoordinate.CoordinateY);
		}

		private bool HasFoodCollision()
		{
			int snakeHeadCoordinateX = this.snake.Head.CoordinateX;
			int snakeHeadCoordinateY = this.snake.Head.CoordinateY;

			int foodCoordinateX = this.food.FoodCoordinate.CoordinateX;
			int foodCoordinateY = this.food.FoodCoordinate.CoordinateY;

			return snakeHeadCoordinateX == foodCoordinateX &&
				   snakeHeadCoordinateY == foodCoordinateY;
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
