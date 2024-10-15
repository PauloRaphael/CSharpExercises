using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFiles.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int quantity { get; set; }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            this.quantity = quantity;
        }
    }
}
