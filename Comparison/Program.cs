using Entities;

List<Product> products = new List<Product>();

products.Add(new Product("TV", 900.00));
products.Add(new Product("Notebook", 1200.00));
products.Add(new Product("Tablet", 450.00));

products.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

foreach(Product product in products)
{
    Console.WriteLine(product);
}