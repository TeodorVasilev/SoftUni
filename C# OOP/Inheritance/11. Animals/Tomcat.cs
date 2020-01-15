namespace Animals
{
	using System.Text;

	public class Tomcat : Cat
	{
		private const string defaultGender = "Male";

		public Tomcat(string name, int age) 
			: base(name, age, defaultGender)
		{
		}

		public override string ProduceSound()
		{
			return "MEOW";
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("Tomcat");
			sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
			sb.Append($"{this.ProduceSound()}");

			return sb.ToString();
		}
	}
}
