using System;
using System.Collections.Generic;
using System.Linq;

namespace MinersTask
{
	public class MinerTask
	{
		public static void Main()
		{
			var resources = new Dictionary<string, int>();

			while (true)
			{
				var name = Console.ReadLine();

				if (name.ToLower() == "stop")
				{
					break;
				}

				var amount = int.Parse(Console.ReadLine());

				if (!resources.ContainsKey(name))
				{
					resources[name] = 0;
				}

				resources[name] += amount;
			}

			Console.WriteLine(string.Join(Environment.NewLine, resources.Select(kvp => $"{kvp.Key} -> {kvp.Value}")));

		}
	}
}