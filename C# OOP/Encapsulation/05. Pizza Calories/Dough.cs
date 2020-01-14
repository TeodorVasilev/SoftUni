namespace _05._Pizza_Calories
{
	using System;
	using System.Collections.Generic;

	public class Dough
	{
		private const double caloriesPerGram = 2;
		
		private string flourType;
		private string bakingTechnique;
		private double weight;
		private Dictionary<string, double> flourTypesModifiers;
		private Dictionary<string, double> techniqueTypesModifiers;
		
		public Dough(string flourType, string bakingTechnique, double weight)
		{
			this.flourTypesModifiers = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase);
			this.SeedFlourTypes();
			this.techniqueTypesModifiers = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase);
			this.SeedTechniqueTypes();
			this.FlourType = flourType;
			this.BakingTechnique = bakingTechnique;
			this.Weight = weight;
		}

		public string FlourType
		{
			get => this.flourType;

			private set
			{
				if(!this.flourTypesModifiers.ContainsKey(value))
				{
					throw new ArgumentException("Invalid type of dough.");
				}

				this.flourType = value;
			}
		}

		public string BakingTechnique
		{
			get => this.bakingTechnique;

			private set
			{
				if(!this.techniqueTypesModifiers.ContainsKey(value))
				{
					throw new ArgumentException("Invalid type of dough.");
				}

				this.bakingTechnique = value;
			}
		}

		public double Weight
		{
			get => this.weight;

			private set
			{
				if(value < 1 || value > 200)
				{
					throw new ArgumentException("Dough weight should be in the range [1..200].");
				}

				this.weight = value;
			}
		}

		public double CalculateCalories()
		{
			return ((caloriesPerGram * this.Weight) * this.flourTypesModifiers[this.FlourType] * this.techniqueTypesModifiers[this.BakingTechnique]);
		}

		private void SeedFlourTypes()
		{
			this.flourTypesModifiers.Add("White", 1.5);
			this.flourTypesModifiers.Add("Wholegrain", 1.0);
		}

		private void SeedTechniqueTypes()
		{
			this.techniqueTypesModifiers.Add("Crispy", 0.9);
			this.techniqueTypesModifiers.Add("Chewy", 1.1);
			this.techniqueTypesModifiers.Add("Homemade", 1.0);
		}
	}
}
