namespace MilitaryElite
{
	using System.Text;

	public class Spy : Soldier, ISpy
	{
		public Spy(string id, string firstName, string lastName, int codeNumber) 
			: base(id, firstName, lastName)
		{
			this.CodeNumber = codeNumber;
		}

		public int CodeNumber { get; private set; }

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(base.ToString());
			sb.Append($"Code Number: {this.CodeNumber}");

			return sb.ToString();
		}
	}
}
