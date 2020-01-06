using System.Text;

namespace P12._Google
{
	public class Parent
	{
		public Parent(string name, string birthday)
		{
			this.Name = name;
			this.Birthday = birthday;
		}

		public string Name { get; set; }

		public string Birthday { get; set; }

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine("Parents:");
			sb.AppendLine($"{this.Name} {this.Birthday}");

			return sb.ToString();
		}
	}
}
