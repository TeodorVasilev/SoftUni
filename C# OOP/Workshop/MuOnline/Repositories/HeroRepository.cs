namespace MuOnline.Repositories
{
    using MuOnline.Models.Heroes.HeroContracts;
    using MuOnline.Repositories.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HeroRepository : IRepository<IHero>
    {
        private readonly List<IHero> heroes;

        public HeroRepository()
        {
            this.heroes = new List<IHero>();
        }

        public IReadOnlyCollection<IHero> Repository
            => this.heroes.AsReadOnly();

        public void Add(IHero item)
        {
            if(item == null)
            {
                throw new ArgumentNullException("Hero cannot be null!");
            }

            this.heroes.Add(item);
        }

        public IHero Get(string item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("Hero cannot be null!");
            }

            var targetItem = this.heroes.FirstOrDefault(x => ((IIdentifiable)x).Username == item);

            return targetItem;
        }

        public bool Remove(IHero item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("Hero cannot be null!");
            }

            bool isRemoved = this.heroes.Remove(item);

            return isRemoved;
        }
    }
}
