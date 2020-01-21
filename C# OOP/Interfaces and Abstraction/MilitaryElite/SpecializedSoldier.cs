namespace MilitaryElite
{
	using System;
	using System.Text;

	public class SpecializedSoldier : Private, ISpecializedSoldier
	{
		private string corps;

		public SpecializedSoldier(string id, string firstName, string lastName, decimal salary, string corps) 
			: base(id, firstName, lastName, salary)
		{
			this.Corps = corps;
		}

		public string Corps
		{
			get => this.corps;

			private set
			{
				if(value != "Airforces" && value != "Marines")
				{
					throw new ArgumentException("Invalid Corps!");
				}

				this.corps = value;
			}
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(base.ToString());
			sb.Append($"Corps: {this.Corps}");

			return sb.ToString();
		}
	}
}
