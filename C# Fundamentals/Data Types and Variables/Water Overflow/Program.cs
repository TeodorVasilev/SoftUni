namespace Water_Overflow
{
	using System;
	public class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int capacity = 255;

			for (int i = 0; i < n; i++)
			{
				int liters = int.Parse(Console.ReadLine());

				if(liters > capacity)
				{
					Console.WriteLine("Insufficient capacity!");
				}
				else
				{
					capacity -= liters;
				}
			}

			Console.WriteLine(255 - capacity);
		}
	}
}
