namespace Animals
{
	using System;

	public abstract class Animal
	{
		private string name;
		private int age;
		private string gender;

		public Animal(string name, int age, string gender)
		{
			this.Name = name;
			this.Age = age;
			this.Gender = gender;
		}

		public string Name
		{
			get => this.name;

			set
			{
				if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("Invalid input!");
				}

				this.name = value;
			}
		}

		public int Age
		{
			get => this.age;

			set
			{
				if(value < 0)
				{
					throw new ArgumentException("Invalid input!");
				}

				this.age = value;
			}
		}

		public string Gender
		{
			get => this.gender;

			set
			{
				if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("Invalid input!");
				}

				this.gender = value;
			}
		}

		public virtual string ProduceSound()
		{
			return "";
		}
	}
}
