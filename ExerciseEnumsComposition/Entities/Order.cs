using ExerciseEnumsComposition.Entities.Enums;
using System.Text;

namespace ExerciseEnumsComposition.Entities
{
    internal class Order
    {
        public Client Client { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = [];

        public Order(Client client, OrderStatus status)
        {
            Client = client;
            Moment = DateTime.Now;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            return Items.Sum(item => item.SubTotal());
        }

        internal string OrderSummary()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString());
            sb.Append("Order status");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name + " ");
            sb.Append("(" + Client.Date  + ") - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order items: ");
            foreach(OrderItem item in Items)
            {
                sb.Append(item.Product.Name);
                sb.Append(", $" + item.Price);
                sb.Append(" Quantity: " +  item.Quantity);
                sb.AppendLine(", " + " Subtotal: $" + item.SubTotal());
            }

            sb.Append("Total prince: ");
            sb.AppendLine("$" + Total().ToString());

            return sb.ToString();
        }
    }
}
