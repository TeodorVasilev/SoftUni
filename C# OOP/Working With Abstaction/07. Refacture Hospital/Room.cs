namespace _07._Refacture_Hospital
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public class Room : IEnumerable<Patient>, IComparable<Room>
	{
		private const int patientsCount = 3;

		public Room(int number)
		{
			this.Number = number;
			this.Patients = new List<Patient>();
		}

		public int Number { get; set; }

		public List<Patient> Patients { get; set; }

		public bool ChekForFreePlace()
		{
			if (this.Patients.Count < 3)
			{
				return true;
			}

			return false;
		}

		public int CompareTo(Room other)
		{
			return this.Number.CompareTo(other.Number);
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
