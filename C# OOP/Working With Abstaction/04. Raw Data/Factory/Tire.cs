namespace _04._Raw_Data.Factory
{
	public class Tire
	{
		private int age;

		public Tire(double pressure, int age)
		{
			this.Pressure = pressure;
			this.age = age;
		}
		
		public double Pressure { get; set; }
	}
}
