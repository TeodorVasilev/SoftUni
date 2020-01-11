namespace _07._Refacture_Hospital
{
	using System.Collections.Generic;

	public class DepartmentComparer : IComparer<Department>
	{
		public int Compare(Department x, Department y)
		{
			return x.Name.CompareTo(y.Name);
		}
	}
}
