using LinqExercise.Entities;
using System.Collections.Generic;
using System.Globalization;

Console.Write("Enter full file path: ");
string path = Console.ReadLine();

List<Product> products = new List<Product>();

using (StreamReader sr = File.OpenText(path))
{
    while (!sr.EndOfStream)
    {
        string[] line = sr.ReadLine().Split(',');
        products.Add(new Product(line[0], double.Parse(line[1], CultureInfo.InvariantCulture)));
    }
}

double avg = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();

Console.WriteLine("Averege Price = " + avg.ToString("N2", CultureInfo.InvariantCulture));

var abaixoDaMedia = from p in products
                    where p.Price < avg
                    orderby p.Name descending
                    select p.Name;

foreach (string name in abaixoDaMedia )
{
    Console.WriteLine(name);
}
