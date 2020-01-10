namespace _04._Raw_Data
{
	public class Cargo
	{
		private int weight;

		public Cargo(int weight, string type)
		{
			this.weight = weight;
			this.Type = type;
		}

		public string Type { get; set; }
	}
}
