namespace P13._Family_Tree
{
	public class Person
	{
		public Person(string data)
		{
			if(int.TryParse(data[0].ToString(), out _))
			{
				this.BirthDate = data;
			}
			else
			{
				this.Name = data;
			}
		}

		public Person(string name, string birthDate)
		{
			this.Name = name;
			this.BirthDate = birthDate;
		}
		
		public string Name { get; set; }

		public string BirthDate { get; set; }

		public override string ToString()
		{
			return $"{this.Name} {this.BirthDate}";
		}
	}
}
