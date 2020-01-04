using P01._Define_Class_Person;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Oldest_Family_Member
{
	public class Family
	{
		private List<Person> members = new List<Person>();
		
		public void AddMember(Person member)
		{
			this.members.Add(member);
		}
		
		public Person GetOldestMember()
		{
			return this.members.OrderByDescending(x => x.Age).FirstOrDefault();
		}
	}
}
