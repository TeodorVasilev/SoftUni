namespace Teamwork_Projects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Team
    {
        public Team(string creatorName, string name)
        {
            this.Name = name;
            this.Creator = creatorName;
            this.Members = new List<string>();
        }

        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }

        public void AddMember()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int teamsToRegister = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamsToRegister; i++)
            {
                string[] creatorTeam = Console.ReadLine().Split('-');

                string creatorName = creatorTeam[0];
                string teamName = creatorTeam[1];

                Team team = new Team(creatorName, teamName);

                if(!teams.Select(t => t.Name).Contains(team.Name))
                {
                    if(!teams.Select(t => t.Creator).Contains(team.Creator))
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

            string input = Console.ReadLine();

            while (input != "end of assignment")
            {

            }
        }
    }
}
