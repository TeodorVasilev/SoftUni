namespace Array_Manipulator
{
	using System;
    using System.Linq;

    class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

			string input = Console.ReadLine();

			while (input != "end")
			{
				string[] commandArgs = input.Split();
				string command = commandArgs[0];

				if(command == "exchange")
				{
					int index = int.Parse(commandArgs[1]);

					if(ValidateIndex(numbers, index))
					{
						numbers = Exchange(numbers, index);
					}
					else
					{
						Console.WriteLine("Invalid index");
						input = Console.ReadLine();
						continue;
					}
				}
				else if(command == "max")
				{
					FindAndPrintMaxIndex(numbers, commandArgs);
				}
				else if(command == "min")
				{
					FindAndPrintMinIndex(numbers, commandArgs);
				}
				else if(command == "first")
				{
					PrintFirstEvenOrOdd(numbers, commandArgs);
				}
				else if(command == "last")
				{
					PrintLastEvenOrOdd(numbers, commandArgs);
				}

				input = Console.ReadLine();
			}

			Console.WriteLine($"[{string.Join(", ", numbers)}]");
		}

		//Print array[count] of last even or odd elements
		static void PrintLastEvenOrOdd(int[] numbers, string[] commandArgs)
		{
			int neededCount = int.Parse(commandArgs[1]);

			if (neededCount > numbers.Length)
			{
				Console.WriteLine("Invalid count");
				return;
			}

			int index = 0;

			int[] lastElements = new int[neededCount];

			if (commandArgs[2] == "even")
			{
				for (int i = numbers.Length - 1; i >= 0; i--)
				{
					if (numbers[i] % 2 == 0 && index < neededCount)
					{
						lastElements[index] = numbers[i];
						index++;
					}
				}
			}
			else if(commandArgs[2] == "odd")
			{
				for (int i = numbers.Length - 1; i >= 0; i--)
				{
					if (numbers[i] % 2 != 0 && index < neededCount)
					{
						lastElements[index] = numbers[i];
						index++;
					}
				}
			}

			if (index >= neededCount)
			{
				Array.Reverse(lastElements);
				Console.WriteLine($"[{string.Join(", ", lastElements)}]");
			}
			else
			{
				int[] temp = new int[index];
				Array.Copy(lastElements, temp, index);
				Array.Reverse(temp);
				Console.WriteLine($"[{string.Join(", ", temp)}]");
			}
		}

		//Print array[count] of first even or odd elements
		static void PrintFirstEvenOrOdd(int[] numbers, string[] commandArgs)
		{
			int neededCount = int.Parse(commandArgs[1]);
			
			if (neededCount > numbers.Length)
			{
				Console.WriteLine("Invalid count");
				return;
			}

			int index = 0;

			int[] firstElements = new int[neededCount];

			if(commandArgs[2] == "even")
			{
				for (int i = 0; i < numbers.Length; i++)
				{
					if(numbers[i] % 2 == 0 && index < neededCount)
					{
						firstElements[index] = numbers[i];
						index++;
					}
				}
			}
			else if(commandArgs[2] == "odd")
			{
				for (int i = 0; i < numbers.Length; i++)
				{
					if (numbers[i] % 2 != 0 && index < neededCount)
					{
						firstElements[index] = numbers[i];
						index++;
					}
				}
			}

			if(index >= neededCount)
			{
				Console.WriteLine($"[{string.Join(", ", firstElements)}]");
			}
			else
			{
				int[] temp = new int[index];
				Array.Copy(firstElements, temp, index);
				Console.WriteLine($"[{string.Join(", ", temp)}]");
			}
		}

		//Print index of min even or odd element
		static void FindAndPrintMinIndex(int[] numbers, string[] commandArgs)
		{
			int minElement = int.MaxValue;
			int index = int.MinValue;

			if (commandArgs[1] == "even")
			{
				for (int i = 0; i < numbers.Length; i++)
				{
					if (numbers[i] % 2 == 0)
					{
						if (numbers[i] < minElement)
						{
							minElement = numbers[i];
							index = i;
						}
						else if(numbers[i] == minElement)
						{
							minElement = numbers[i];
							index = i;
						}
					}
				}

				if (minElement == int.MaxValue)
				{
					Console.WriteLine("No matches");
					return;
				}
				else
				{
					Console.WriteLine(index);
				}
			}
			else
			{
				for (int i = 0; i < numbers.Length; i++)
				{
					if (numbers[i] % 2 != 0)
					{
						if (numbers[i] < minElement)
						{
							minElement = numbers[i];
							index = i;
						}
						else if (numbers[i] == minElement)
						{
							minElement = numbers[i];
							index = i;
						}
					}
				}

				if (minElement == int.MaxValue)
				{
					Console.WriteLine("No matches");
					return;
				}
				else
				{
					Console.WriteLine(index);
				}
			}
		}

		//Print index of max even or odd element
		static void FindAndPrintMaxIndex(int[] numbers, string[] commandArgs)
		{
			int maxElement = int.MinValue;
			int index = int.MinValue;

			if (commandArgs[1] == "even")
			{
				for (int i = 0; i < numbers.Length; i++)
				{
					if (numbers[i] % 2 == 0)
					{
						if(numbers[i] > maxElement)
						{
							maxElement = numbers[i];
							index = i;
						}
						else if(numbers[i] == maxElement)
						{
							maxElement = numbers[i];
							index = i;
						}
					}
				}

				if(maxElement == int.MinValue)
				{
					Console.WriteLine("No matches");
					return;
				}
				else
				{
					Console.WriteLine(index);
				}
			}
			else
			{
				for (int i = 0; i < numbers.Length; i++)
				{
					if (numbers[i] % 2 != 0)
					{
						if (numbers[i] > maxElement)
						{
							maxElement = numbers[i];
							index = i;
						}
						else if (numbers[i] == maxElement)
						{
							maxElement = numbers[i];
							index = i;
						}
					}
				}

				if (maxElement == int.MinValue)
				{
					Console.WriteLine("No matches");
					return;
				}
				else
				{
					Console.WriteLine(index);
				}
			}
		}

		//Exchange - Split after given index and change the places of two resulting arrays
		static int[] Exchange(int[] numbers, int index)
		{
			int[] temp = numbers.Skip(index + 1).ToArray();

			int[] temp2 = numbers.Take(index + 1).ToArray();

			int[] result = temp.Concat(temp2).ToArray();

			return result;
		}

		static bool ValidateIndex(int[] numbers, int index)
		{
			if (index < 0 || index > numbers.Length - 1)
			{
				return false;
			}

			return true;
		}
	}
}
