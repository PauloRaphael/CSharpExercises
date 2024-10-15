using OOPDateTimeExercise.Entities;
using System.Globalization;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> products = [];
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine($"Product #{i + 1} data");
                Console.Write("Common, used or imported (c/u/i)? ");
                char kind = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (kind)
                {
                    case 'c':

                        products.Add(new Product(name, price));
                        break;

                    case 'u':

                        Console.Write("Manufactured Date (DD/MM/YYYY): ");
                        DateOnly date = DateOnly.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        products.Add(new UsedProduct(name, price, date));

                        break;
                    case 'i':
                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        products.Add(new ImportedProduct(name, price, customsFee));
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");

            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}