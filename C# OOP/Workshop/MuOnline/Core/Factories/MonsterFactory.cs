namespace MuOnline.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using Core.Factories.Contracts;
    using Models.Monsters.Contracts;

    public class MonsterFactory : IMonsterFactory
    {
        public IMonster Create(string monsterTypeName)
        {
            var monsterTypeNameLower = monsterTypeName.ToLower();

            var type = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(x => (typeof(IMonster).IsAssignableFrom(x)))
                .FirstOrDefault(x => x.Name.ToLower() == monsterTypeNameLower);

            //TODO not sure? > test

            if(type == null)
            {
                throw new ArgumentNullException("Invalid monster type!");
            }

            var monster = (IMonster)Activator.CreateInstance(type);

            return monster;
        }
    }
}
