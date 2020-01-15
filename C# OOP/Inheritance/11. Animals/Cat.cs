namespace Animals
{
	using System.Text;

	public class Cat : Animal
	{
		public Cat(string name, int age, string gender) 
			: base(name, age, gender)
		{
		}

		public override string ProduceSound()
		{
			return "Meow meow";
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("Cat");
			sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
			sb.Append($"{this.ProduceSound()}");

			return sb.ToString();
		}
	}
}
