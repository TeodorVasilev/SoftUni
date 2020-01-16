using System;

namespace Ferrari
{
	public class StartUp
	{
		static void Main(string[] args)
		{
			string driverName = Console.ReadLine();

			ICar car = new Ferrari(driverName);

			Console.WriteLine(car);
		}
	}
}
