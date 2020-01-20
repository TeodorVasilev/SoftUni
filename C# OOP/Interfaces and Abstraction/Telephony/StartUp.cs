namespace Telephony
{
	using System;
	using System.Linq;

	public class StartUp
	{
		static void Main(string[] args)
		{
			string[] numbers = Console.ReadLine().Split(' ').ToArray();

			string[] urls = Console.ReadLine().Split(' ').ToArray();

			Smartphone smartphone = new Smartphone();

			for (int i = 0; i < numbers.Length; i++)
			{
				try
				{
					Console.WriteLine(smartphone.Calling(numbers[i]));
				}
				catch (ArgumentException ex)
				{
					Console.WriteLine(ex.Message);
				}
			}

			for (int i = 0; i < urls.Length; i++)
			{
				try
				{
					Console.WriteLine(smartphone.Browsing(urls[i]));
				}
				catch (ArgumentException ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
		}
	}
}
