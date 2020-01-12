namespace _09._Refacture_Sneaking
{
	using System;

	public class Program
	{
		static void Main(string[] args)
		{
			int rows = int.Parse(Console.ReadLine());
			int cols = 0;

			string[] roomLines = new string[rows];

			for (int i = 0; i < rows; i++)
			{
				string roomLine = Console.ReadLine();
				cols = roomLine.Length;

				roomLines[i] = roomLine;
			}

			char[,] room = new char[rows, cols];

			int enemyRow = 0;
			int enemyCol = 0;

			int[] playerPosition = new int[2];

			for (int row = 0; row < rows; row++)
			{
				var line = roomLines[row].ToCharArray();

				for (int col = 0; col < cols; col++)
				{
					room[row, col] = line[col];

					if(room[row, col] == 'N')
					{
						enemyRow = row;
						enemyCol = col;
					}

					if(room[row, col] == 'S')
					{
						playerPosition[0]= row;
						playerPosition[1] = col;
					}
				}
			}
			
			var directions = Console.ReadLine().ToCharArray();

			for (int i = 0; i < directions.Length; i++)
			{
				for (int row = 0; row < rows; row++)
				{
					for (int col = 0; col < cols; col++)
					{	
						//Enemy movement

						if(room[row,col] == 'b')
						{
							if(row >= 0 && row < rows && col + 1 >= 0 && col + 1 < cols)
							{
								room[row, col] = '.';
								room[row, col + 1] = 'b';
								col++;
							}
							else
							{
								//If on matrix edge flips direction

								room[row, col] = 'd';
							}
						}
						else if(room[row,col] == 'd')
						{
							if(row >= 0 && row < rows && col - 1 >= 0 && col - 1 < cols)
							{
								room[row, col] = '.';
								room[row, col - 1] = 'd';
							}
							else
							{
								room[row, col] = 'b';
							}
						}
					}
				}
				
				//Chek if player is killed

				if(CheckIfPlayerDies(room, playerPosition[0], playerPosition[1]))
				{
					room[playerPosition[0], playerPosition[1]] = 'X';

					Console.WriteLine($"Sam died at {playerPosition[0]}, {playerPosition[1]}");

					Print(room);

					return;
				}

				//Player Movement
				
				room[playerPosition[0], playerPosition[1]] = '.';

				playerPosition = PlayerMove(room, playerPosition, 'S', directions[i]);

				room[playerPosition[0], playerPosition[1]] = 'S';
				
				//Chek if enemy is killed

				if (ChekIfEnemyIsKilled(playerPosition[0], enemyRow))
				{
					room[enemyRow, enemyCol] = 'X';

					Console.WriteLine("Nikoladze killed!");

					Print(room);

					return;
				}
			}
		}

		public static int[] PlayerMove(char[,] room, int[] playerPosition, char player, char direction)
		{
			int row = playerPosition[0];
			int col = playerPosition[1];

			switch (direction)
			{
				case 'U':
					row = row - 1;
					playerPosition[0] = row;
					break;
				case 'D':
					row = row + 1;
					playerPosition[0] = row;
					break;
				case 'L':
					col = col - 1;
					playerPosition[1] = col;
					break;
				case 'R':
					col = col + 1;
					playerPosition[1] = col;
					break;
				case 'W':
					break;
			}

			return playerPosition;
		}

		public static bool CheckIfPlayerDies(char[,] room, int playerRow, int playerCol)
		{
			for (int row = 0; row < room.GetLength(0); row++)
			{
				for (int col = 0; col < room.GetLength(1); col++)
				{
					if (room[row, col] == 'b')
					{
						if (playerRow == row && playerCol > col)
						{
							return true;
						}
					}
					else if (room[row, col] == 'd')
					{
						if (playerRow == row && playerCol < col)
						{
							return true;
						}
					}
				}
			}

			return false;
		}

		public static bool ChekIfEnemyIsKilled(int playerRow, int enemyRow)
		{
			if (playerRow == enemyRow)
			{
				return true;
			}

			return false;
		}

		public static void Print(char[,] room)
		{
			for (int row = 0; row < room.GetLength(0); row++)
			{
				for (int col = 0; col < room.GetLength(1); col++)
				{
					Console.Write(room[row, col]);
				}

				Console.WriteLine();
			}
		}
	}
}
