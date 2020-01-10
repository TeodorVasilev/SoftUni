namespace _05._Refacture_Car_Salesman
{
	using System.Text;

	public class Engine
	{
		private const string offset = "  ";
		
		private int power;
		private int displacement;
		private string efficiency;

		public Engine(string model, int power)
			:this(model, power, -1, "n/a")
		{
		}

		public Engine(string model, int power, int displacement)
			:this(model, power, displacement, "n/a")
		{
		}

		public Engine(string model, int power, string efficiency)
			: this(model, power, -1, efficiency)
		{
		}

		public string Model { get; set; }

		public Engine(string model, int power, int displacement, string efficiency)
		{
			this.Model = model;
			this.power = power;
			this.displacement = displacement;
			this.efficiency = efficiency;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("{0}{1}:\n", offset, this.Model);
			sb.AppendFormat("{0}{0}Power: {1}\n", offset, this.power);
			sb.AppendFormat("{0}{0}Displacement: {1}\n", offset, this.displacement == -1 ? "n/a" : this.displacement.ToString());
			sb.AppendFormat("{0}{0}Efficiency: {1}\n", offset, this.efficiency);

			return sb.ToString();
		}
	}
}
