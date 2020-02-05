namespace Calculate_Rectangle_Area
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			double a = double.Parse(Console.ReadLine());
			double b = double.Parse(Console.ReadLine());

			Console.WriteLine(GetArea(a, b));
		}

		static double GetArea(double a, double b)
		{
			return a * b;
		}
	}
}
