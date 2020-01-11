namespace _07._Refacture_Hospital
{
	using System;

	public class Patient : IComparable<Patient>
	{
		public Patient(string name)
		{
			this.Name = name;
		}

		public string Name { get; private set; }

		public int CompareTo(Patient other)
		{
			return this.Name.CompareTo(other.Name);
		}
		
		public override string ToString()
		{
			return $"{this.Name}";
		}
	}
}
