namespace MuOnline.Core.Factories
{
    using MuOnline.Core.Factories.Contracts;
    using MuOnline.Models.Heroes.HeroContracts;
    using System;
    using System.Linq;
    using System.Reflection;

    public class HeroFactory : IHeroFactory
    {
        public IHero Create(string heroType, string username)
        {
            var hero = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name.ToLower() == heroType);

            if(hero == null)
            {
                throw new ArgumentNullException("Invalid hero type!");
            }
        }
    }
}
