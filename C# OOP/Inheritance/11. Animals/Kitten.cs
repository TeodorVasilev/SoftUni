namespace Animals
{
	using System;
	using System.Text;

	public class Kitten : Cat
	{
		private const string defaultGender = "Female";

		public Kitten(string name, int age) 
			: base(name, age, defaultGender)
		{
		}

		public override string ProduceSound()
		{
			return "Meow";
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("Kitten");
			sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
			sb.Append($"{this.ProduceSound()}");

			return sb.ToString();
		}
	}
}
