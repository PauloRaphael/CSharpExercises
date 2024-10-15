using System.Globalization;

namespace Entities
{
    internal class Product
    {
        public String Name { get; set; }
        public double Price { get; set; }

        public Product(String name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
