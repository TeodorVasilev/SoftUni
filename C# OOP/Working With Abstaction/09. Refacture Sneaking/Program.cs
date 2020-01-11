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
			
			int playerCurrentRow = 0;
			int playerCurrentCol = 0;

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
						playerCurrentRow = row;
						playerCurrentCol = col;
					}
				}
			}
			
			var directions = Console.ReadLine().ToCharArray();
			
			for (int i = 0; i < directions.Length; i++)
			{
				for (int row = 0; row < room.GetLength(0); row++)
				{
					for (int col = 0; col < room.GetLength(1); col++)
					{
						if(CheckIfPlayerDies(room, playerCurrentRow, playerCurrentCol))
						{
							room[playerCurrentRow, playerCurrentCol] = 'X';

							PrintIfPlayerDies(room, playerCurrentRow, playerCurrentCol);

							return;
						}

						if(ChekIfEnemyIsKilled(playerCurrentRow, enemyRow))
						{
							room[enemyRow, enemyCol] = 'X';

							PrintIfEnemyIsKilled(room);

							return;
						}
						
						if (room[row, col] == 'b')
						{
							//if (EnemyDirectionSwitch(room, col))
							//{
							//	room[row, col] = 'd';
							//}
							//else
							//{
								EnemyMove(room, row, col, 'b');
							//}
						}
						if (room[row, col] == 'd')
						{
							//if (EnemyDirectionSwitch(room, col))
							//{
							//	room[row, col] = 'b';
							//}
							//else
							//{
								EnemyMove(room, row, col, 'b');
							//}
						}
						if (room[row, col] == 'S')
						{
							PlayerMove(room, row, col, 'S', directions[i]);
							playerCurrentRow = row;
							playerCurrentCol = col;
						}
					}
				}
			}
		}

		public static void PlayerMove(char[,] room, int row, int col, char player, char direction)
		{
			switch(direction)
			{
				case 'U':
					room[row, col] = '.';
					room[row - 1, col] = player;
					break;
				case 'D':
					room[row, col] = '.';
					room[row + 1, col] = player;
					break;
				case 'L':
					room[row, col] = '.';
					room[row, col - 1] = player;
					break;
				case 'R':
					room[row, col] = '.';
					room[row, col + 1] = player;
					break;
				case 'W':
					break;
			}
		}
		
		public static void EnemyMove(char[,] room, int row, int col, char enemy)
		{
			if (EnemyDirectionSwitch(room, row, col))
			{
				if (enemy == 'b')
				{
					room[row, col] = 'd';
				}
				else if (enemy == 'd')
				{
					room[row, col] = 'b';
				}

				return;
			}

			room[row, col] = '.';

			if(enemy == 'b')
			{
				room[row, col + 1] = enemy;
			}
			else if(enemy == 'd')
			{
				room[row, col - 1] = enemy;
			}
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

		public static bool EnemyDirectionSwitch(char[,] room ,int row, int col)
		{
			if (col == 0 || col == room.GetLength(1) - 1)
			{
				return true;
			}

			return false;
		}

		public static void PrintIfEnemyIsKilled(char[,] room)
		{
			Console.WriteLine("Nikoladze killed!");

			for (int row = 0; row < room.GetLength(0); row++)
			{
				for (int col = 0; col < room.GetLength(1); col++)
				{
					Console.Write(room[row,col]);
				}

				Console.WriteLine();
			}
		}

		public static void PrintIfPlayerDies(char[,] room, int playerRow, int playerCol)
		{
			Console.WriteLine($"Sam died at {playerRow}, {playerCol}");

			for (int row = 0; row < room.GetLength(0); row++)
			{
				for (int col = 0; col < room.GetLongLength(1); col++)
				{
					Console.Write(room[row,col]);
				}

				Console.WriteLine();
			}
		}
	}
}
