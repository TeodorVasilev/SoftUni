using PersonsInfo;
using System.Collections.Generic;

namespace _01._Sort_Persons_by_Name_and_Age
{
	public class Team
	{
		private string name;
		private List<Person> firstTeam;
		private List<Person> reserveTeam;

		public Team(string name)
		{

		}

		public List<Person> FirstTeam
		{
			get
			{
				return this.firstTeam;
			}
			set
			{
				this.firstTeam = value;
			}
		}

		public List<Person> ReserveTeam
		{
			get
			{
				return this.reserveTeam;
			}
			set
			{
				this.reserveTeam = value;
			}
		}

		public void AddPlayer(Person person)
		{

		}

	}
}
