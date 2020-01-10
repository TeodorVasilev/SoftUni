namespace _04._Raw_Data.Factory
{
	public class EngineFactory
	{
		public Engine Create(int speed, int power)
		{
			return new Engine(speed, power);
		}
	}
}
