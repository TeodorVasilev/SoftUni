using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordsCount
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var wordsReader = new StreamReader(@"words.txt"))
			{
				using (var textReader = new StreamReader(@"text.txt"))
				{
					using (var resultWriter = new StreamWriter(@"output.txt", true))
					{
						var wordsCount = new Dictionary<string, int>();
						var line = wordsReader.ReadLine();
						while (line != null)
						{
							var splitted = line.Split(' ');
							for (int i = 0; i < splitted.Length; i++)
							{
								wordsCount.Add(splitted[i], 0);
							}
							line = wordsReader.ReadLine();
						}

						var textLine = textReader.ReadLine();
						while (textLine != null)
						{
							var splitted = textLine.Split(new char[] { '-', '.', ',', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

							for (int i = 0; i < splitted.Length; i++)
							{
								if (wordsCount.ContainsKey(splitted[i].ToLower()))
								{
									wordsCount[splitted[i].ToLower()]++;
								}
							}

							textLine = textReader.ReadLine();
						}

						var ordered = wordsCount.OrderByDescending(x => x.Value);

						foreach (var kvp in ordered)
						{
							resultWriter.WriteLine($"{kvp.Key} - {kvp.Value}");
						}
					}
				}
			}
		}
	}
}
