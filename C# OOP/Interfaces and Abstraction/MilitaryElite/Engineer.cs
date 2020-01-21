namespace MilitaryElite
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class Engineer : SpecializedSoldier, IEngineer
	{
		public Engineer(string id, string firstName, string lastName, decimal salary, string corps, List<Repair> repairs) 
			: base(id, firstName, lastName, salary, corps)
		{
			this.Repairs = repairs;
		}

		public IReadOnlyCollection<Repair> Repairs { get; }

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(base.ToString());
			sb.AppendLine($"Repairs:");

			foreach (var repair in this.Repairs)
			{
				sb.AppendLine(repair.ToString());
			}

			return sb.ToString().TrimEnd();
		}
	}
}
