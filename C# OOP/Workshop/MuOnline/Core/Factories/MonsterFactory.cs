using MuOnline.Core.Factories.Contracts;
using MuOnline.Models.Monsters.Contracts;

namespace MuOnline.Core.Factories
{
    public class MonsterFactory : IMonsterFactory
    {
        public IMonster Create(string monsterType, int attackPoints, int defensePoints)
        {
            throw new System.NotImplementedException();
        }
    }
}
