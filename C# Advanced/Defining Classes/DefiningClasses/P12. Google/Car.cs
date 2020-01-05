namespace P12._Google
{
	class Car
	{
		public Car(string model, int speed)
		{
			this.Model = model;
			this.Speed = speed;
		}

		public string Model { get; set; }

		public int Speed { get; set; }
	}
}
