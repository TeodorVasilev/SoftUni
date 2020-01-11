namespace _07._Refacture_Hospital
{
	using System.Collections;
	using System.Collections.Generic;

	public class Doctor : IEnumerable<Patient>
	{
		public Doctor(string firstName, string lastName)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Patients = new List<Patient>();
		}

		public List<Patient> Patients { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public void AddPatient(Patient patient)
		{
			this.Patients.Add(patient);
		}
		
		public IEnumerator<Patient> GetEnumerator()
		{
			for (int i = 0; i < this.Patients.Count; i++)
			{
				yield return this.Patients[i];
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
			=> this.GetEnumerator();
	}
}
