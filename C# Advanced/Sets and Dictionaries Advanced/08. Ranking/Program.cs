using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
	class Program
	{
		static void Main(string[] args)
		{
			var contestPassword = new Dictionary<string, string>();

			var input = Console.ReadLine();

			while (input != "end of contests")
			{
				var inputParts = input.Split(':').ToArray();

				var contestName = inputParts[0];
				var contestPass = inputParts[1];

				if(!contestPassword.ContainsKey(contestName))
				{
					contestPassword[contestName] = contestPass;
				}

				input = Console.ReadLine();
			}

			var userContestPoints = new SortedDictionary<string, Dictionary<string, int>>();

			var submissionsInput = Console.ReadLine();

			while (submissionsInput != "end of submissions")
			{
				var inputParts = submissionsInput.Split(new string[] { "=>" }, StringSplitOptions.RemoveEmptyEntries).ToArray();

				var contestName = inputParts[0];
				var contestPass = inputParts[1];
				var userName = inputParts[2];
				var userPoints = int.Parse(inputParts[3]);

				if(contestPassword.ContainsKey(contestName) && contestPassword.ContainsValue(contestPass))
				{
					if(!userContestPoints.ContainsKey(userName))
					{
						userContestPoints[userName] = new Dictionary<string, int>() { {contestName, userPoints } };
					}

					if(!userContestPoints[userName].ContainsKey(contestName))
					{
						userContestPoints[userName].Add(contestName, userPoints);
					}

					if(userContestPoints[userName][contestName] < userPoints)
					{
						userContestPoints[userName][contestName] = userPoints;
					}
				}
				else
				{
					submissionsInput = Console.ReadLine();
					continue;
				}

				submissionsInput = Console.ReadLine();
			}

			var usersTotalPoints = new Dictionary<string, int>();

			foreach (var kvp in userContestPoints)
			{
				usersTotalPoints[kvp.Key] = kvp.Value.Values.Sum();
			}

			string bestUser = usersTotalPoints.Keys.Max();
			int bestPoints = usersTotalPoints.Values.Max();

			foreach (var kvp in usersTotalPoints)
			{
				if (kvp.Value == bestPoints)
				{
					Console.WriteLine($"Best candidate is {kvp.Key} with total {kvp.Value} points.");
				}
			}
			Console.WriteLine("Ranking: ");

			foreach (var kvp in userContestPoints)
			{
				Console.WriteLine(kvp.Key);

				Dictionary<string, int> dict = kvp.Value;
				dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

				foreach (var contestPoints in dict)
				{
					Console.WriteLine($"#  {contestPoints.Key} -> {contestPoints.Value}");
				}
			}
		}
	}
}
