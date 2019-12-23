using System;
using System.IO;

namespace _01.OddLines
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var reader = new StreamReader(@"Input.txt"))
			{
				int counter = 0;

				while (true)
				{
					var line = reader.ReadLine();

					if (line == null)
					{
						break;
					}

					if(counter % 2 != 0)
					{
						Console.WriteLine(line);
					}

					counter++;
				}
			}
		}
	}
}
