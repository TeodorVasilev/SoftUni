namespace MuOnline.Core.Commands
{
    using Core.Commands.Contracts;
    using Models.Heroes.HeroContracts;
    using Models.Items.Contracts;
    using Repositories.Contracts;

    public class AddItemToHero : ICommand
    {
        private const string successfullMessage = "Succesfully added {0} to hero {1}";

        private readonly IRepository<IHero> heroRepository;
        private readonly IRepository<IItem> itemRepository;

        public AddItemToHero(IRepository<IHero> heroRepository, IRepository<IItem> itemRepository)
        {
            this.heroRepository = heroRepository;
            this.itemRepository = itemRepository;
        }

        public string Execute(string[] inputArgs)
        {
            string heroUsername = inputArgs[0];
            string itemName = inputArgs[1];

            var hero = this.heroRepository.Get(heroUsername);
            var item = this.itemRepository.Get(itemName);

            hero.Inventory.AddItem(item);

            return string.Format(successfullMessage, item.GetType().Name, heroUsername);
        }
    }
}
