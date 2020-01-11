namespace _07._Refacture_Hospital
{
	using System.Collections.Generic;

	public class DoctorComparer : IComparer<Doctor>
	{
		public int Compare(Doctor x, Doctor y)
		{
			var nameCompare = x.FirstName.CompareTo(y.FirstName);

			if(nameCompare == 0)
			{
				nameCompare = x.LastName.CompareTo(y.LastName);
			}

			return nameCompare;
		}
	}
}
