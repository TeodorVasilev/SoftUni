namespace MuOnline.Core.Commands
{
	using Core.Commands.Contracts;
    using Models.Heroes.HeroContracts;
    using Models.Monsters.Contracts;
    using Repositories.Contracts;

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

		public string Execute(string[] inputArgs)
		{
			string heroUsername = inputArgs[0];
			string monsterName = inputArgs[1];

			var hero = this.heroRepository.Get(heroUsername);
			var monster = this.monsterRepository.Get(monsterName);

			var heroAtackPoints = hero.TotalAttackPoints;
			var monsterAtackPoints = hero.TotalAttackPoints;

			//fix hero totalstamina points

			while (hero.IsAlive && monster.IsAlive)
			{
				monster.TakeDamage(heroAtackPoints);
				//hero.TakeDamage(monsterAtackPoints);
				var xp = monster.TakeDamage(heroAtackPoints);
				((IProgress)hero).AddExperience(xp);
			}

			return string.Format(commandMessage, hero.IsAlive ? monster.GetType().Name : heroUsername);
		}
	}
}
