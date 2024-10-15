using Entities;
using System.Globalization;

Console.Write("Write full file path: ");
string path = Console.ReadLine();

Console.Write("Enter Salary: ");
double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

List<Employee> employees = new List<Employee>();

using (StreamReader sr = File.OpenText(path))
{
    while (!sr.EndOfStream)
    {
        string[] line = sr.ReadLine().Split(',');
        employees.Add(new Employee(line[0], line[1], double.Parse(line[2], CultureInfo.InvariantCulture)));
    }
}


var EmailImpostoDeRenda = (from e in employees
                           where e.Salary > salary
                           orderby e.Name
                           select e.Email);

double sumNamesWithM = (from e in employees
                        where e.Name[0] == 'M'
                        select e.Salary).Sum();


Console.WriteLine("Email of people whose salary is more than 2000.00: ");
foreach (var email in EmailImpostoDeRenda)
{
    Console.WriteLine(email);
}

Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sumNamesWithM);
