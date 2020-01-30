namespace Lady_Bugs
{
	using System;
    using System.Linq;

    public class Program
	{
		static void Main(string[] args)
		{
			//Field size
			int fieldSize = int.Parse(Console.ReadLine());

			//Initial indexes of bugs. May or may not be inside field range
			int[] initialIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

			int[] field = new int[fieldSize];

			//Initializing bugs: bug = 1, empty = 0;
			for (int i = 0; i < initialIndexes.Length; i++)
			{
				if (initialIndexes[i] < field.Length)
				{
					field[initialIndexes[i]] = 1;
				}
			}

			//Receiving commands until "end" {ladybug index} {direction} {fly length}
			//If ladybug lands on another it continues to fly by the same fly length
			//If its lands out of range it goes away
			//If there is no bug on given index nothing happens
			//If given index is out of range nothing happens
			string input = Console.ReadLine();

			while (input != "end")
			{
				string[] commands = input.Split();

				int bugIndex = int.Parse(commands[0]);

				//Chek if there is a bug on given index and if index is in range
				if(ChekIfThereIsABug(field, bugIndex) == false)
				{
					input = Console.ReadLine();
					continue;
				}

				string direction = commands[1];

				int flyLength = int.Parse(commands[2]);

				//Chek if fly length is in range
				if(ChekIfFlyLengthIsInRange(field, bugIndex, flyLength, direction) == false)
				{
					field[bugIndex] = 0;
					input = Console.ReadLine();
					continue;
				}

				int jumpsCount = 1;


				if(direction == "left")
				{
					while (jumpsCount != 0)
					{
						//If there is a bug continue to fly by the same length
						if (ChekIfThereIsABug(field, bugIndex - flyLength))
						{
							jumpsCount++;
							flyLength *= jumpsCount;

							//Chek if the bug flies out of range
							if(ChekIfFlyLengthIsInRange(field, bugIndex, flyLength, direction) == false)
							{
								field[bugIndex] = 0;
								break;
							}
							else
							{
								continue;
							}
						}

						if(ChekIfThereIsABug(field, bugIndex - flyLength) == false)
						{
							field[bugIndex] = 0;
							field[bugIndex - flyLength] = 1;
							jumpsCount = 0;
						}
					}
				}
				else if(direction == "right")
				{

				}

				input = Console.ReadLine();
			}
		}

		public static bool ChekIfThereIsABug(int[] field, int index)
		{
			//Chek if index is in range
			if (index < 0 || index > field.Length - 1)
			{
				return false;
			}

			if(field[index] == 1)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static bool ChekIfFlyLengthIsInRange(int[] field, int index, int flyLength, string direction)
		{
			if(flyLength < 0)
			{
				return false;
			}

			if(direction == "left")
			{
				if(index - flyLength < 0)
				{
					return false;
				}
				else
				{
					return true;
				}
			}
			else
			{
				if (index + flyLength > field.Length - 1)
				{
					return false;
				}
				else
				{
					return true;
				}
			}
		}
	}
}
