using MuOnline.Core.Commands.Contracts;
using MuOnline.Core.Factories.Contracts;
using MuOnline.Models.Monsters.Contracts;
using MuOnline.Repositories.Contracts;

namespace MuOnline.Core.Commands
{
    public class AddMonsterCommand : ICommand
    {
        private const string succesfullMesage = "Successfully created monster: {0}";

        private readonly IRepository<IMonster> monsterRepository;
        private readonly IMonsterFactory monsterFactory;

        public AddMonsterCommand(IRepository<IMonster> monsterRepository, IMonsterFactory monsterFactory)
        {
            this.monsterRepository = monsterRepository;
            this.monsterFactory = monsterFactory;
        }

        public string Execute(string[] inputArgs)
        {
            string monsterType = inputArgs[0];

            var monster = monsterFactory.Create(monsterType);

            this.monsterRepository.Add(monster);

            return string.Format(succesfullMesage, monster.GetType().Name);
        }
    }
}
