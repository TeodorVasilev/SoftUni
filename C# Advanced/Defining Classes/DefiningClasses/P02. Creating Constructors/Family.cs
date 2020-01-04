using System;
using System.Collections.Generic;
using System.Linq;

namespace P01._Define_Class_Person
{
	public class Family
	{
		private List<Person> members;

		public List<Person> Members { get; set; }

		public void AddMember(Person member)
		{
			Members.Add(member);
		}

		public Person GetOldestMember()
		{
			Person oldest = Members.Max
			
		}
	}
}
