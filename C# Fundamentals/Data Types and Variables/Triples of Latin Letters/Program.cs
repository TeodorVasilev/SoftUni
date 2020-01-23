namespace Triples_of_Latin_Letters
{
	using System;

	public class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				for (int k = 0; k < n; k++)
				{
					for (int j = 0; j < n; j++)
					{
						char firstChar = (char)('a' + i);
						char secondChar = (char)('a' + k);
						char thirdChar = (char)('a' + j);

						Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
					}
				}
			}
		}
	}
}
