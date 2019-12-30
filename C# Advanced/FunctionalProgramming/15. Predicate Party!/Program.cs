using System;
using System.Collections.Generic;
using System.Linq;

namespace _15.Predicate_Party_
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> guests = Console.ReadLine().Split().ToList();

			string input = Console.ReadLine();

			while (input != "Party!")
			{
				var tokens = input.Split().ToArray();

				var command = tokens[0];
				var filterCommand = tokens[1];
				var criteria = tokens[2];

				//Func<string, string, bool> predicate = (x, c) => x.StartsWith(c);

				if(command == "Double")
				{
					List<string> guestsToAdd = new List<string>();

					if (filterCommand == "StartsWith")
					{
						guestsToAdd = guests.Where(x => x.StartsWith(criteria)).ToList();
					}
					else if (filterCommand == "EndsWith")
					{
						guestsToAdd = guests.Where(x => x.EndsWith(criteria)).ToList();
					}
					else if(filterCommand == "Length")
					{
						guestsToAdd = guests.Where(x => x.Length == int.Parse(criteria)).ToList();
					}

					foreach (var name in guestsToAdd)
					{
						int index = guests.IndexOf(name);

						guests.Insert(index + 1, name);
					}
				}
				else if(command == "Remove")
				{
					List<string> guestsToRemove = new List<string>();

					if(filterCommand == "StartsWith")
					{
						guests.RemoveAll(x => x.StartsWith(criteria));
					}
					else if(filterCommand == "EndsWith")
					{
						guests.RemoveAll(x => x.EndsWith(criteria));
					}
					else if(filterCommand == "Length")
					{
						guests.RemoveAll(x => x.Length == int.Parse(criteria));
					}
				}

				input = Console.ReadLine();
			}

			Console.WriteLine(guests.Any()? $"{string.Join(", ", guests)} are going to the party!": "Nobody is going to the party!");
		}

		static Func<string, string, bool> GetFunc(string filterCommand)
		{

		}
	}
}
