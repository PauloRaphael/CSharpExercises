namespace ExerciseEnumsComposition.Entities
{
    internal class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
            Price = Product.Price;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}
