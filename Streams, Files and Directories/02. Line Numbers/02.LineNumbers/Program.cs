using System;
using System.IO;

namespace _02.LineNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var reader = new StreamReader(@"..\..\..\Input1.txt"))
			{
				int counter = 1;

				while (true)
				{
					var line = reader.ReadLine();

					if(line == null)
					{
						break;
					}

					line = $"{counter}. {line}";
					counter++;

					using (var writer = new StreamWriter("Output.txt", true))
					{
						writer.WriteLine(line);
					}
				}
			}
		}
	}
}
