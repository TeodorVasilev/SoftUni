using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _04.MergeFiles
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var firstTextReader = new StreamReader(@"input1.txt"))
			{
				using (var secondTextReader = new StreamReader(@"input2.txt"))
				{
					using (var textWriter = new StreamWriter(@"output.txt", true))
					{
						var firstTextContents = new List<string>();

						var line = firstTextReader.ReadLine();

						while (line != null)
						{
							firstTextContents.Add(line);

							line = firstTextReader.ReadLine();
						}

						var secondTextContents = new List<string>();

						line = secondTextReader.ReadLine();

						while (line != null)
						{
							secondTextContents.Add(line);

							line = secondTextReader.ReadLine();
						}

						var merged = firstTextContents.Concat(secondTextContents).ToList();
						var result = merged.OrderBy(x => x);

						foreach (var item in result)
						{
							textWriter.WriteLine(item);
						}
					}
				}
			}
		}
	}
}
