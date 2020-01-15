namespace Animals
{
	using System.Text;

	public class Dog : Animal
	{
		public Dog(string name, int age, string gender) 
			: base(name, age, gender)
		{
		}

		public override string ProduceSound()
		{
			return "Woof!";
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("Dog");
			sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
			sb.Append($"{this.ProduceSound()}");

			return sb.ToString();
		}
	}
}
