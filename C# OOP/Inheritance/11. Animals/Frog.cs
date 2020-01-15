namespace Animals
{
	using System.Text;

	public class Frog : Animal
	{
		public Frog(string name, int age, string gender) : base(name, age, gender)
		{
		}

		public override string ProduceSound()
		{
			return "Ribbit";
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("Frog");
			sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
			sb.Append($"{this.ProduceSound()}");

			return sb.ToString();
		}
	}
}
