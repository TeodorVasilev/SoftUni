namespace Spice_Must_Flow
{
	using System;

	public class Program
	{
		static void Main(string[] args)
		{
			int startingYield = int.Parse(Console.ReadLine());

			int daysCount = 0;

			int yieldStorage = 0;

			if (startingYield < 100)
			{
				Console.WriteLine(daysCount);
				Console.WriteLine(yieldStorage);

				return;
			}

			while (startingYield >= 100)
			{
				daysCount++;
				yieldStorage += startingYield;
				
				if(yieldStorage >= 26)
				{
					yieldStorage -= 26;
				}
				else
				{
					yieldStorage = 0;
				}

				startingYield -= 10;
			}

			yieldStorage -= 26;

			Console.WriteLine(daysCount);
			Console.WriteLine(yieldStorage);
		}
	}
}
