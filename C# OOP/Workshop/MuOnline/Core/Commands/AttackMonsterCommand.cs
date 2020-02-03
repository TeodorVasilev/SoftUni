namespace MuOnline.Core.Commands
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	using MuOnline.Core.Commands.Contracts;
    using MuOnline.Models.Heroes.HeroContracts;
    using MuOnline.Models.Monsters.Contracts;
    using MuOnline.Repositories;
    using MuOnline.Repositories.Contracts;

    public class AttackMonsterCommand : ICommand
	{
		private const string commandMessage = "{0} is dead!";

		private readonly IRepository<IHero> heroRepository;
		private readonly IRepository<IMonster> monsterRepository;

		public AttackMonsterCommand(IRepository<IHero> heroRepository, IRepository<IMonster> monsterRepository)
		{
			this.heroRepository = heroRepository;
			this.monsterRepository = monsterRepository;
		}

		//Hero Username
		//Monster Name
		public string Execute(string[] inputArgs)
		{
			string heroUsername = inputArgs[0];
			string monsterName = inputArgs[1];

			var hero = this.heroRepository.Get(heroUsername);
			var monster = this.monsterRepository.Get(monsterName);

			var heroAtackPoints = hero.TotalAttackPoints;
			var monsterAtackPoints = hero.TotalAttackPoints;

			while (hero.IsAlive && monster.IsAlive)
			{
				hero.TakeDamage(monsterAtackPoints);
				var xp = monster.TakeDamage(heroAtackPoints);
				((IProgress)hero).AddExperience(xp);
			}

			return string.Format(commandMessage, hero.IsAlive ? monster.GetType().Name : heroUsername);
		}
	}
}
