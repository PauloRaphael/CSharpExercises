using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDateTimeExercise.Entities
{
    internal class UsedProduct : Product
    {
        public DateOnly ManufacturedDate { get; set; }

        public UsedProduct(string name, double price, DateOnly manufacturedDate) : base (name, price)
        {
            ManufacturedDate = manufacturedDate;
        }

        public sealed override string PriceTag()
        {
            return Name + " (used) $ " + Price.ToString("0.00", CultureInfo.InvariantCulture) + " (Manufactured Date: " + ManufacturedDate.ToString() + ")";
        }
    }
}
