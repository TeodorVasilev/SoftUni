namespace _02._Division
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());

			int[] divisors = new int[] { 10, 7, 6, 3, 2 };

			string message = "";

			for (int i = 0; i < divisors.Length; i++)
			{
				if(number % divisors[i] == 0)
				{
					message = $"The number is divisible by {divisors[i]}";
					break;
				}
				else if(i == divisors.Length - 1)
				{
					message = "Not divisible";
				}
			}

			Console.WriteLine(message);
		}
	}
}
