namespace MuOnline.Models.Inventories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;
    using Items.Contracts;

    public class Inventory : IInventory
    {
        private readonly List<IItem> items;

        public Inventory()
        {
            this.items = new List<IItem>();
        }

        public IReadOnlyCollection<IItem> Items
            => this.items.AsReadOnly();

        public void AddItem(IItem item)
        {
            if(item == null)
            {
                throw new ArgumentNullException("Item cannot be null!");
            }

            this.items.Add(item);
        }

        public bool RemoveItem(IItem item)
        {
            if(item == null)
            {
                throw new ArgumentNullException("Item cannot be null!");
            }

            var isRemove = this.items.Remove(item);

            return isRemove;
        }

        public IItem GetItem(string item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("Item cannot be null!");
            }

            var targetItem = this.items.FirstOrDefault(i => i.GetType().Name == item);

            return targetItem;
        }
    }
}
