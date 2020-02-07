namespace Center_Point
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			double x1 = double.Parse(Console.ReadLine());
			double y1 = double.Parse(Console.ReadLine());
			double x2 = double.Parse(Console.ReadLine());
			double y2 = double.Parse(Console.ReadLine());

			PrintClosePointToCenter(x1, y1, x2, y2);
		}

		static void PrintClosePointToCenter(double x1, double y1, double x2, double y2)
		{
			double p1 = Math.Abs(Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2)));
			double p2 = Math.Abs(Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2)));

			if (p2 < p1)
			{
				Console.WriteLine($"({x2}, {y2})");
			}
			else
			{
				Console.WriteLine($"({x1}, {y1})");
			}
		}
	}
}
