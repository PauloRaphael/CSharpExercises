using ExerciseEnumsComposition.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEnumsComposition.Entities
{
    internal class ItemCreator
    {

        public static Client CreateClient()
        {
            Console.WriteLine("Enter Client Data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateOnly date = DateOnly.Parse(Console.ReadLine());

            return new Client(name, email, date);
        }

        public static Order CreateOrder(Client client)
        {
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine(), true);

            return new Order(client, status);
        }

        public static OrderItem CreateOrderItem(int i) {

            Console.WriteLine("Enter #" + (i + 1) + " item data:");
            Console.Write("Product name: ");
            string name = Console.ReadLine();
            Console.Write("Product price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Product product = new Product(name, price);

            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            return new OrderItem(product, quantity);

        }

    }
}
