using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAbstractMethods.Entities
{
    internal class LegalPerson : Person
    {

        public double HealthExpenditures { get; set; }

        public LegalPerson(string name, double annualIncome, double healthExpenditures) : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public sealed override double GetTaxes()
        {
            return ((AnnualIncome < 20000) ? (AnnualIncome * 0.15) : (AnnualIncome * 0.25)) - (HealthExpenditures * 0.5);
        }
    }
}
