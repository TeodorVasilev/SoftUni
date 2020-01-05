using System;
using System.Collections.Generic;
using System.Linq;

namespace P11._Pokemon_Trainer
{
	class StartUp
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

			while (input != "Tournament")
			{
				string[] inputParts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

				string trainerName = inputParts[0];
				string pokemonName = inputParts[1];
				string pokemonElement = inputParts[2];
				int pokemonHealth = int.Parse(inputParts[3]);

				Pokemon pokemon = new Pokemon();
				pokemon.Name = pokemonName;
				pokemon.Element = pokemonElement;
				pokemon.Health = pokemonHealth;

				if(!trainers.ContainsKey(trainerName))
				{
					trainers[trainerName] = new Trainer(trainerName);

					trainers[trainerName].Pokemons = new List<Pokemon>();
				}
				trainers[trainerName].Pokemons.Add(pokemon);
				trainers[trainerName].Badges = 0;

				input = Console.ReadLine();
			}
			
			input = Console.ReadLine();

			while (input != "End")
			{
				string currentElement = input;

				foreach (var trainer in trainers.Values)
				{
					if(trainer.Pokemons.Any(e => e.Element == currentElement))
					{
						trainer.Badges++;
					}
					else
					{
						foreach (var pokemon in trainer.Pokemons)
						{
							pokemon.Health -= 10;
						}
					}
					HealthChek(trainer);
				}

				input = Console.ReadLine();
			}

			foreach (var trainer in trainers.Values.OrderByDescending(x => x.Badges))
			{
				Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
			}
		}

		public static void HealthChek(Trainer trainer)
		{
			for (int i = 0; i < trainer.Pokemons.Count; i++)
			{
				if(trainer.Pokemons[i].Health <= 0)
				{
					trainer.Pokemons.Remove(trainer.Pokemons[i]);
				}
			}
		}
	}
}
