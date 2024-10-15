using ExerciseEnumsComposition.Entities;

namespace ExerciseEnumsComposition
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Client client = ItemCreator.CreateClient();

            Order order = ItemCreator.CreateOrder(client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {

                order.AddItem(ItemCreator.CreateOrderItem(i));
            }

            Console.WriteLine();

            Console.WriteLine(order.OrderSummary());

        }
    }
}
