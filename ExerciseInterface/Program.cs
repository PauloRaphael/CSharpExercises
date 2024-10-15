using ExerciseInterface.Entities;
using ExerciseInterface.Services;
using System.Globalization;

namespace ExerciseFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");

            int number = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateOnly date = DateOnly.Parse(Console.ReadLine());

            Console.Write("Contract value: ");
            double contractTotal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Number of intallments: ");
            int numberOfIntallments = int.Parse(Console.ReadLine());

            ContractService contractService = new ContractService(new PayPalService());

            Contract contract = new Contract(number, date, contractTotal);

            contractService.ProcessContract(contract, numberOfIntallments);

            Console.WriteLine(contract.PrintIntallments());

        }
    }
}