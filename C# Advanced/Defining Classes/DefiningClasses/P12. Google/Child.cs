using System.Text;

namespace P12._Google
{
	public class Child
	{
		public Child(string name, string birthday)
		{
			this.Name = name;
			this.Birthday = birthday;
		}

		public string Name { get; set; }

		public string Birthday { get; set; }

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine("Children:");
			sb.AppendLine($"{this.Name} {this.Birthday}");

			return sb.ToString();
		}
	}
}
