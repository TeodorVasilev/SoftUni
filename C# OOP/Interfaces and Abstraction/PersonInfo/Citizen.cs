﻿namespace PersonInfo
{
	using System;

	public class Citizen : IPerson, IIdentifiable, IBirthable
	{
		private string name;
		private int age;
		private string id;
		private string birthdate;

		public Citizen(string name, int age, string id, string birthdate)
		{
			this.Name = name;
			this.Age = age;
			this.Id = id;
			this.Birthdate = birthdate;
		}

		public string Name
		{
			get => this.name;

			private set
			{
				if(string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("Name cannot be empty!");
				}

				this.name = value;
			}
		}

		public int Age
		{
			get => this.age;

			private set
			{
				if(value < 0)
				{
					throw new ArgumentException("Age cannot be negative");
				}

				this.age = value;
			}
		}

		public string Birthdate
		{
			get => this.birthdate;

			private set
			{
				if(string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("Birthdate cannot be empty!");
				}

				this.birthdate = value;
			}
		}

		public string Id
		{
			get => this.id;

			private set
			{
				if(string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("Id cannot be empty!");
				}

				this.id = value;
			}
		}
	}
}
