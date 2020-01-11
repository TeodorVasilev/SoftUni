namespace Refacture_Jedi_Galaxy
{
	using System;
	using System.Linq;

	public class Program
	{
		public  static void Main(string[] args)
		{
			int[] dimensions = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
			int rows = dimensions[0];
			int cols = dimensions[1];

			int[,] matrix = new int[rows, cols];

			FillMatrix(matrix, rows, cols);

			string command = Console.ReadLine();

			int score = 0;

			while (command != "Let the Force be with you")
			{
				int[] playerStartCoordinates = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

				command = Console.ReadLine();

				int[] evilStartCoordinates = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

				Point evilStart = new Point(evilStartCoordinates[0], evilStartCoordinates[1]);

				Player evilPlayer = new Player("Evil", evilStart);
				
				while (evilPlayer.Position.Row >= 0 && evilPlayer.Position.Col >= 0)
				{
					if (evilPlayer.Position.Row >= 0 &&
						evilPlayer.Position.Row < matrix.GetLength(0) &&
						evilPlayer.Position.Col >= 0 &&
						evilPlayer.Position.Col < matrix.GetLength(1))
					{
						matrix[evilPlayer.Position.Row, evilPlayer.Position.Col] = 0;
					}

					evilPlayer.Position.Row--;
					evilPlayer.Position.Col--;
				}

				Point playerStart = new Point(playerStartCoordinates[0], playerStartCoordinates[1]);

				Player player = new Player("Ivo", playerStart);

				while (player.Position.Row >= 0 && player.Position.Col < matrix.GetLength(1))
				{
					if (player.Position.Row >= 0 &&
						player.Position.Row < matrix.GetLength(0) &&
						player.Position.Col >= 0 &&
						player.Position.Col < matrix.GetLength(1))
					{
						score += matrix[player.Position.Row, player.Position.Col];
					}

					player.Position.Col++;
					player.Position.Row--;
				}

				command = Console.ReadLine();
			}

			Console.WriteLine(score);
		}

		public static void FillMatrix(int[,] matrix, int rows, int cols)
		{
			int value = 0;

			for (int row = 0; row < rows; row++)
			{
				for (int col = 0; col < cols; col++)
				{
					matrix[row, col] = value;
					value++;
				}
			}
		}
	}
}
