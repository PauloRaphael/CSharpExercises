using System.Linq;

//data source
int[] numbers = { 2, 3, 4, 5 };

// query
IEnumerable<int> result = numbers
    .Where(x => x % 2 == 0)
    .Select(x => x * 10);

//Execute the query

foreach(int x in result)
{
    Console.WriteLine(x);
}   