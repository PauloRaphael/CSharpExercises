using System.Globalization;

namespace ExerciseAbstractMethods.Entities
{
    internal abstract class Person
    {

        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        protected Person(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double GetTaxes();

        public string GetTaxesString()
        {
            return $"{Name}: $ {GetTaxes().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
