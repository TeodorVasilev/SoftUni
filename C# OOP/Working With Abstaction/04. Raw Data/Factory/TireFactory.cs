namespace _04._Raw_Data.Factory
{
	public class TireFactory
	{
		public Tire Create(double tirePressure, int tireAge)
		{
			return new Tire(tirePressure, tireAge);
		}
	}
}
