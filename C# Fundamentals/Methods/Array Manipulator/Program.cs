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

					if(index < 0 || index > numbers.Length - 1)
					{
						Console.WriteLine("Invalid index");
					}



				}


				input = Console.ReadLine();
			}
		}
	}
}
