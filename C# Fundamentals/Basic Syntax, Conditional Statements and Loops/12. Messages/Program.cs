namespace _12._Messages
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			string result = string.Empty;
			
			for (int i = 0; i < n; i++)
			{
				int number = int.Parse(Console.ReadLine());

				if (number == 0)
				{
					result += " ";
				}
				else
				{
					int lenght = number.ToString().Length;
					int mainDigit = number % 10;
					int startIndex = (mainDigit - 2) * 3;

					if (mainDigit == 8 || mainDigit == 9)
					{
						startIndex++;
					}

					int letterIndex = startIndex + lenght - 1;
					result += (char)(97 + letterIndex);
				}
			}

			Console.WriteLine(result);
		}
	}
}
