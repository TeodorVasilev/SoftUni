using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
	public class Mission : IMission
	{
		private string state;

		public Mission(string codeName, string state)
		{
			this.CodeName = codeName;
			this.State = state;
		}

		public string CodeName { get; private set; }

		public string State
		{
			get => this.state;

			set
			{
				if(value != "inProgress" && value != "Finished")
				{
					throw new ArgumentException("Invalid State!");
				}

				this.state = value;
			}
		}

		public override string ToString()
		{
			return $"Code Name: {this.CodeName} State: {this.State}";
		}
	}
}
