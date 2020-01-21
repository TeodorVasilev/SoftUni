using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
	public class LieutenantGeneral : Private, ILieutenantGeneral
	{
		public LieutenantGeneral(string id, string firstName, string lastName, decimal salary, List<Private> privates) 
			: base(id, firstName, lastName, salary)
		{
			this.Privates = privates;
		}

		public IReadOnlyCollection<Private> Privates { get; }

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(base.ToString());
			sb.AppendLine("Privates:");

			foreach (var @private in this.Privates)
			{
				sb.AppendLine(@private.ToString());
			}

			return sb.ToString().TrimEnd();
		}
	}
}
