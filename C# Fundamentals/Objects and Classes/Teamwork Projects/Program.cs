namespace Teamwork_Projects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int teamsToRegister = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamsToRegister; i++)
            {
                string[] newTeam = Console.ReadLine().Split('-');

                string creatorName = newTeam[0];
                string teamName = newTeam[1];

                Team team = new Team(creatorName, teamName);

                if (!teams.Select(t => t.Name).Contains(teamName))
                {
                    if(!teams.Select(t => t.Creator).Contains(creatorName))
                    {
                        teams.Add(team);
                        Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
                    }
                    else
                    {
                        Console.WriteLine($"{team.Creator} cannot create another team!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {team.Name} was already created!");
                }
            }

            string membersRegistration = Console.ReadLine();

            while (membersRegistration != "end of assignment")
            {
                string[] memberTeam = membersRegistration.Split("->");

                string memberName = memberTeam[0];
                string teamName = memberTeam[1];

                if(!teams.Select(t => t.Name).Contains(teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Select(x => x.Members).Any(x => x.Contains(memberName)) || teams.Select(x => x.Creator).Contains(memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                }
                else
                {
                    Team team = teams.FirstOrDefault(t => t.Name == teamName);

                    team.AddMember(memberName);
                }

                membersRegistration = Console.ReadLine();
            }

            var disbanded = teams.OrderBy(t => t.Name).Where(t => t.Members.Count == 0);

            var sorted = teams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name).Where(x => x.Members.Count > 0);

            foreach (var team in sorted)
            {
                Console.WriteLine(team);
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in disbanded)
            {
                Console.WriteLine(team.Name);
            }
        }
    }
}
