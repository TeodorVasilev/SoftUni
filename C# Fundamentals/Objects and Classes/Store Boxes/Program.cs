namespace Store_Boxes
{
    using System;
    using System.Text;

    public class Item
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }

    public class Box
    {
        public Box()
        {
            this.Item = new Item();
        }

        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public decimal Price { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.SerialNumber}");

            sb.AppendLine($"-- {this.Item.Name} - ${this.Item.Price}: {this.ItemQuantity}");

            sb.AppendLine($"-- ${this.Price}");

            return sb.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputArgs = input.Split();



                input = Console.ReadLine();
            }
        }
    }
}
