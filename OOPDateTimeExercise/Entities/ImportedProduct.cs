using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDateTimeExercise.Entities
{
    internal class ImportedProduct : Product
    {

        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsFee) : base (name, price)
        {
            CustomsFee = customsFee;
        }

        public sealed override string PriceTag()
        {
            return Name + " $ " + (Price + CustomsFee).ToString("0.00", CultureInfo.InvariantCulture)+ " (Customs fee: " + CustomsFee.ToString("0.00", CultureInfo.InvariantCulture) + ")";
        }
    }
}
