using System.Globalization;

namespace OOPDateTimeExercise.Entities
{
    internal class Product
    {

        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name + " $ " + Price.ToString("0.00", CultureInfo.InvariantCulture);
        }
    }
}
