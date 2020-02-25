namespace Teamwork_Projects
{
    using System.Collections.Generic;
    using System.Text;

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

        public void AddMember(string username)
        {
            this.Members.Add(username);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.Name}");
            sb.AppendLine($"- {this.Creator}");

            foreach (var member in this.Members.OrderBy(x => x))
            {
                sb.AppendLine($"-- {member}");
            }

            return sb.ToString().Trim();
        }
    }
}
