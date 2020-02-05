namespace Add_and_Subtract
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int c = int.Parse(Console.ReadLine());

			Console.WriteLine(Subtract(a,b,c));
		}

		static int Sum(int a, int b)
		{
			return a + b;
		}

		static int Subtract(int a, int b, int c)
		{
			return Sum(a, b) - c;
		}
	}
}
