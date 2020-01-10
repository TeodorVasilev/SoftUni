namespace _07._Refacture_Hospital
{
	public class Bed
	{
		public Bed(string name)
		{
			this.Patient = new Patient(name);
		}

		public Patient Patient { get; set; }
	}
}
