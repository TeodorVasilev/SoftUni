namespace _04._Raw_Data.Factory
{
	public class Engine
	{
		private int speed;

		public Engine(int speed, int power)
		{
			this.speed = speed;
			this.Power = power;
		}
		
		public int Power { get; set; }
	}
}
