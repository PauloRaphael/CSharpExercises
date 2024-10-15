using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAbstractMethods.Entities
{
    internal class LegalEntity : Person
    {
        public int NumberOfEmployees { get; set; }

        public LegalEntity(string name, double annualIncome, int numberOfEmployees) : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public sealed override double GetTaxes()
        {
            return (NumberOfEmployees < 10) ? (AnnualIncome * 0.16) : (AnnualIncome * 0.14);
        }
    }
}
