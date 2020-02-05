namespace Math_Power
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			double num = double.Parse(Console.ReadLine());
			double power = double.Parse(Console.ReadLine());

			Console.WriteLine(Math.Pow(num, power));
		}
	}
}
