using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cars
{
	struct Car
	{
		public int x;
		public int y;
		public char c;
		public ConsoleColor color;
	}

	class Program
	{
		static void Main(string[] args)
		{
			double speed = 100.0;
			int playFieldWidth = 5;
			int livesCount = 5;

			//Remove scrollbar
			Console.BufferHeight = Console.WindowHeight = 20;
			Console.BufferWidth = Console.WindowWidth = 30;

			//Initialize user car
			Car userCar = new Car();
			userCar.x = 2;
			userCar.y = Console.WindowHeight - 1;
			userCar.c = '@';
			userCar.color = ConsoleColor.Yellow;

			//Falling cars
			Random randomGenerator = new Random();
			List<Car> cars = new List<Car>();
			
			while (true)
			{
				bool hitted = false;

				//Initialize falling cars
				Car newCar = new Car();
				newCar.color = ConsoleColor.Magenta;
				newCar.x = randomGenerator.Next(0, playFieldWidth);
				newCar.y = 0;
				newCar.c = 'H';
				cars.Add(newCar);

				//Implement Car moving (key)
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo pressedKey = Console.ReadKey(true);
					while (Console.KeyAvailable) Console.ReadKey(true);
					if(pressedKey.Key == ConsoleKey.LeftArrow)
					{
						if(userCar.x - 1 >= 0)
						{
							userCar.x = userCar.x - 1;
						}
					}
					else if(pressedKey.Key == ConsoleKey.RightArrow)
					{
						if(userCar.x + 1 < playFieldWidth)
						{
							userCar.x = userCar.x + 1;
						}
					}
				}

				//Move cars
				List<Car> newList = new List<Car>();

				for (int i = 0; i < cars.Count; i++)
				{
					Car oldCar = cars[i];
					Car nextCar = new Car();

					nextCar.x = oldCar.x;
					nextCar.y = oldCar.y + 1;
					nextCar.c = oldCar.c;
					nextCar.color = oldCar.color;

					//Check if falling cars hits Car	
					if (nextCar.y == userCar.y && nextCar.x == userCar.x)
					{
						livesCount--;

						//If hit start over
						hitted = true;
						speed = 100.0;

						if(livesCount <= 0)
						{
							PrintStringOnPosition(8, 10, "GAME OVER!!!", ConsoleColor.Red);
							PrintStringOnPosition(8, 12, "Press [enter] to exit.", ConsoleColor.Red);
							Console.ReadLine();
							return;
						}
					}
					
					if(nextCar.y < Console.WindowHeight)
					{
						newList.Add(nextCar);
					}
				}
				cars = newList;
				
				//Clear console
				Console.Clear();

				//Redraw playfield
				foreach (var car in cars)
				{
					PrintOnPosition(car.x, car.y, car.c, car.color);
				}

				//When crash write 'X'
				if (hitted)
				{
					cars.Clear();
					PrintOnPosition(userCar.x, userCar.y, 'X', ConsoleColor.Red);
				}
				else
				{
					PrintOnPosition(userCar.x, userCar.y, userCar.c, userCar.color);
				}

				//Draw info
				PrintStringOnPosition(8, 4, "Lives: " + livesCount, ConsoleColor.White);
				PrintStringOnPosition(8, 5, "Speed: " + speed, ConsoleColor.White);
				//Slow down cars
				Thread.Sleep((int)(600 - speed));
				speed++;
			}
		}

		static void PrintOnPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.Gray)
		{
			Console.SetCursorPosition(x, y);
			Console.ForegroundColor = color;
			Console.Write(c);
		}

		static void PrintStringOnPosition(int x, int y, string lives, ConsoleColor color = ConsoleColor.Gray)
		{
			Console.SetCursorPosition(x, y);
			Console.ForegroundColor = color;
			Console.Write(lives);
		}
	}
}
