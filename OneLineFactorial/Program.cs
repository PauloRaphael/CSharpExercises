namespace OneLineFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(Factorial(5));
        }
        static int Factorial(int x) => (x == 0) ? 1 : x * Factorial(x - 1);
    }
}