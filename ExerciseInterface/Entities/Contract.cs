
using System.Text;
using System.Globalization;

namespace ExerciseInterface.Entities
{
    internal class Contract
    {

        public int Number {  get; set; }
        public DateOnly Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateOnly date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }

        public string PrintIntallments()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Installments: ");

            foreach (Installment installment in Installments)
            {
                sb.AppendLine(installment.DueDate + " - " + installment.Amount.ToString("F2", CultureInfo.InvariantCulture));
            }    

            return sb.ToString();
        }
    }
}