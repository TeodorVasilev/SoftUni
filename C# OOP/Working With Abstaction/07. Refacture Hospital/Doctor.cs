namespace _07._Refacture_Hospital
{
	using System.Collections.Generic;

	public class Doctor
	{
		public Doctor(string firstName, string lastName)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Patients = new SortedSet<Patient>();
		}

		public SortedSet<Patient> Patients { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public void AddPatient(Patient patient)
		{
			this.Patients.Add(patient);
		}
	}
}
