using System.Globalization;
using ExerciseAbstractMethods.Entities;

namespace ExerciseAbstractMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Person> taxpayers = [];

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer {i + 1} data: ");
                Console.Write("Individual or company(i/c)? ");

                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual Income: ");
                double anusincome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (type)
                {
                    case 'i':

                        Console.Write("Health expenditures: ");
                        double healthexp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        taxpayers.Add(new LegalPerson(name, anusincome, healthexp));
                        break;
                    case 'c':

                        Console.Write("Number of employees: ");
                        int nEmployee = int.Parse(Console.ReadLine());
                        taxpayers.Add(new LegalEntity(name, anusincome, nEmployee));
                        break;
                }
            }

            Console.WriteLine();

            Console.WriteLine("TAXES PAID:");

            foreach (Person person in taxpayers)
            {
                Console.WriteLine(person.GetTaxesString());
            }

        }
    }
}