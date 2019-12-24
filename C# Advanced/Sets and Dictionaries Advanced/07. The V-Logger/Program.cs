using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.The_V_Logger
{
	class Program
	{
		static void Main(string[] args)
		{
			var usernames = new HashSet<string>();

			var userFollowers = new Dictionary<string, HashSet<string>>();
			var userFollowing = new Dictionary<string, HashSet<string>>();

			while (true)
			{
				string input = Console.ReadLine();

				if(input == "Statistics")
				{
					break;
				}

				string[] splitedInput = input.Split().ToArray();

				if(splitedInput.Length == 4)
				{
					string username = splitedInput[0];

					if(!usernames.Contains(username))
					{
						usernames.Add(username);
						userFollowers.Add(username, new HashSet<string>());
						userFollowing.Add(username, new HashSet<string>());
					}
				}
				else
				{
					string follows = splitedInput[0];
					string followed = splitedInput[2];

					if(usernames.Contains(follows) && usernames.Contains(followed) && follows != followed)
					{
						userFollowers[followed].Add(follows);
						userFollowing[follows].Add(followed);
					}
				}
			}

			Console.WriteLine($"The V-Logger has a total of {usernames.Count} vloggers in its logs.");

			var topUser = userFollowers.OrderByDescending(x => x.Value.Count).ThenBy(x => userFollowing[x.Key].Count).FirstOrDefault();

			Console.WriteLine($"1. {topUser.Key} : {topUser.Value.Count} followers, {userFollowing[topUser.Key].Count} following");

			foreach (var kvp in topUser.Value.OrderBy(a => a))
			{
				Console.WriteLine($"*  {kvp}");
			}

			int count = 2;

			foreach (var kvp in userFollowers.Where(x => x.Key != topUser.Key).OrderByDescending(x => x.Value.Count).ThenBy(x => userFollowing[x.Key].Count))
			{
				Console.WriteLine($"{count}. {kvp.Key} : {kvp.Value.Count} followers, {userFollowing[kvp.Key].Count} following");
				count++;
			}
		}
	}
}
