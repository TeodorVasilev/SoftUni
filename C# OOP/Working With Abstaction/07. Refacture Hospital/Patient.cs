using System;

namespace _07._Refacture_Hospital
{
	public class Patient : IComparable<Patient>
	{
		public Patient(string name)
		{
			this.Name = name;
		}

		public string Name { get; private set; }

		public int CompareTo(Patient other)
		{
			var nameCompare = this.Name.CompareTo(other.Name);

			return nameCompare;
		}
	}
}
