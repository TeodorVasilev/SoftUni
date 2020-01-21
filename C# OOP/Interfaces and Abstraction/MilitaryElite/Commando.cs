namespace MilitaryElite
{
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class Commando : SpecializedSoldier, ICommando
	{
		public Commando(string id, string firstName, string lastName, decimal salary, string corps, List<Mission> missions) 
			: base(id, firstName, lastName, salary, corps)
		{
			this.Missions = missions;
		}

		public IReadOnlyCollection<Mission> Missions { get; }

		public void CompleteMission(string codeName)
		{
			Mission mission = Missions.FirstOrDefault(x => x.CodeName == codeName);

			if(mission != null)
			{
				mission.State = "Complete";
			}
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(base.ToString());
			sb.AppendLine($"Missions:");

			foreach (var mission in this.Missions)
			{
				sb.AppendLine(mission.ToString());
			}

			return sb.ToString().TrimEnd();
		}
	}
}
