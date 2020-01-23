namespace Floating_Equality
{
	using System;

	public class Program
	{
		static void Main(string[] args)
		{
			double firstNum = double.Parse(Console.ReadLine());
			double secondNum = double.Parse(Console.ReadLine());

			double eps = 0.000001;

			if(firstNum < secondNum)
			{
				double temp = firstNum;
				firstNum = secondNum;
				secondNum = temp;
			}

			if(firstNum - secondNum < eps)
			{
				Console.WriteLine("True");
			}
			else
			{
				Console.WriteLine("False");
			}
		}
	}
}
