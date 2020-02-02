namespace MuOnline.Repositories
{
    using MuOnline.Models.Monsters.Contracts;
    using MuOnline.Repositories.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MonsterRepository : IRepository<IMonster>
    {
        private readonly List<IMonster> monsters;

        public MonsterRepository()
        {
            this.monsters = new List<IMonster>();
        }

        public IReadOnlyCollection<IMonster> Repository
            => this.monsters.AsReadOnly();

        public void Add(IMonster item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("Monster cannot be null!");
            }

            this.monsters.Add(item);
        }

        public IMonster Get(string item)
        {
            var targetMonster = this.monsters.FirstOrDefault(n => n.GetType().Name == item);

            if(targetMonster == null)
            {
                throw new ArgumentNullException("Monster cannot be null!");
            }

            return targetMonster;
        }

        public bool Remove(IMonster item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("Monster cannot be null!");
            }

            bool isRemoved = this.monsters.Remove(item);

            return isRemoved;
        }
    }
}
