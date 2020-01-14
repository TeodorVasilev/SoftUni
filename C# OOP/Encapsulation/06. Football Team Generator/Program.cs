namespace _06._Football_Team_Generator
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class Program
	{
		public static void Main(string[] args)
		{
			try
			{
				string input = Console.ReadLine();

				List<Team> teams = new List<Team>();

				while (input != "END")
				{
					string[] teamArgs = input.Split(new char[] { ';',' '}, StringSplitOptions.RemoveEmptyEntries);

					if (teamArgs[0] == "Team")
					{
						string teamName = teamArgs[1];
						try
						{
							Team team = new Team(teamName);

							teams.Add(team);
						}
						catch (ArgumentException ex)
						{
							Console.WriteLine(ex.Message);
						}
					}
					else if (teamArgs[0] == "Add")
					{
						string teamName = teamArgs[1];
						string playerName = teamArgs[2];
						int endurance = int.Parse(teamArgs[3]);
						int sprint = int.Parse(teamArgs[4]);
						int dribble = int.Parse(teamArgs[5]);
						int passing = int.Parse(teamArgs[6]);
						int shooting = int.Parse(teamArgs[7]);

						try
						{
							Team team = GetTeam(teamName, teams);
							
							Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);

							team.AddPlayer(player);
						}
						catch (ArgumentException ex)
						{
							Console.WriteLine(ex.Message);
						}
					}
					else if (teamArgs[0] == "Remove")
					{
						string teamName = teamArgs[1];
						string playerName = teamArgs[2];
						
						try
						{
							Team team = GetTeam(teamName, teams);
							
							team.RemovePlayer(playerName);
						}
						catch (ArgumentException ex)
						{
							Console.WriteLine(ex.Message);
						}
					}
					else if (teamArgs[0] == "Rating")
					{
						string teamName = teamArgs[1];

						try
						{
							Team team = GetTeam(teamName, teams);

							Console.WriteLine(team);
						}
						catch (ArgumentException ex)
						{
							Console.WriteLine(ex.Message);
						}
					}

					input = Console.ReadLine();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		public static Team GetTeam(string teamName, List<Team> teams)
		{
			Team team = teams.FirstOrDefault(t => t.Name == teamName);

			if(team == null)
			{
				throw new ArgumentException($"Team {teamName} does not exist.");
			}

			return team;
		}
	}
}
