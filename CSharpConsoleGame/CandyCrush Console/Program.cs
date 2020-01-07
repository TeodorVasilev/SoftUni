using System;
using System.Collections.Generic;

namespace CandyCrush_Console
{
	class Program
	{
		const int GameWidth = 24;
		const int GameHeight = 11;
		const int CandyFieldWidth = 9;
		const int CandyFieldHeight = 9;
		const int InfoPanelWidth = 13;
		const int InfoPanelHeight = 11;
		const char BorderSymb = '*';
		static int Score = 0;
		static int Level = 1;
		static int Lives = 5;
		static int Moves = 20;
		static int Target = 500;
		static Candy currentCandy;
		static Candy nextCandy;

		static Random random = new Random();

		public struct Candy
		{
			public char c;
			public ConsoleColor color;
		}

		static Candy[] candies = new Candy[]
		{
			//blue //magenta //red //cyan //yellow //green
			new Candy
			{
				c = 'B',
				color = ConsoleColor.Blue
			},
			new Candy
			{
				c = 'P',
				color = ConsoleColor.Magenta
			},
			new Candy
			{
				c = 'R',
				color = ConsoleColor.Red
			},
			new Candy
			{
				c = 'O',
				color = ConsoleColor.Cyan
			},
			new Candy
			{
				c = 'Y',
				color = ConsoleColor.Yellow
			},
			new Candy
			{
				c = 'G',
				color = ConsoleColor.Green
			}
		};

		static void Main(string[] args)
		{
			Console.CursorVisible = false;
			Console.Title = "Console CandyCrush";
			Console.WindowWidth = GameWidth + 1;
			Console.BufferWidth = GameWidth + 1;
			Console.WindowHeight = GameHeight + 1;
			Console.BufferHeight = GameHeight + 1;
			PrintBorders();
			PrintInfoPanel();

			while (true)
			{

			}
		}

		static void StartNewGame()
		{
			//take random candy
			currentCandy = candies[random.Next(0, candies.Length)];
			nextCandy = candies[random.Next(0, candies.Length)];
		}

		static void PrintInfoPanel()
		{
			// center target
			int w = InfoPanelWidth;
			int s = Target.ToString().Length;
			int position = w / 2 - s / 2;
			position = position + CandyFieldWidth + 2;

			Print(1, 13, "Lives:");
			Print(3, 13, "Moves:");
			Print(5, 13, "Target:");
			Print(7, 13, "Score:");
			Print(9, 12, "Controls:");
			Print(2, position, Lives);
			Print(4, position, Moves);
			Print(6, position, Target);
			Print(8, position, Score);
		}

		static void PrintBorders()
		{
			for (int col = 0; col < GameWidth; col++)
			{
				Print(0, col, BorderSymb);
				Print(GameHeight, col, BorderSymb);
			}

			for (int row = 0; row < GameHeight; row++)
			{
				Print(row, 0, BorderSymb);
				Print(row, CandyFieldWidth+1, BorderSymb);
				Print(row, CandyFieldWidth+1 + InfoPanelWidth, BorderSymb);
			}
		}

		static void Print(int row, int col, object data)
		{
			Console.SetCursorPosition(col, row);
			Console.Write(data);
		}
	}
}