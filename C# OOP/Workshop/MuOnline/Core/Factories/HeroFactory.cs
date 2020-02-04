namespace MuOnline.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using Core.Factories.Contracts;
    using Models.Heroes.HeroContracts;

    public class HeroFactory : IHeroFactory
    {
        public IHero Create(string heroType, string username)
        {
            var heroName = heroType.ToLower();

            var type = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name.ToLower() == heroType);

            if(type == null)
            {
                throw new ArgumentNullException("Invalid hero type!");
            }

            var hero = (IHero)Activator.CreateInstance(type, username);

            return hero;
        }
    }
}
