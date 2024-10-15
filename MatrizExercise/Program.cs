namespace ExerciseEnumsComposition
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] values = Console.ReadLine().Split(' ');
            int m = int.Parse(values[0]);
            int n = int.Parse(values[1]);

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                values = Console.ReadLine().Trim().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == num)
                    {
                        Console.WriteLine("Position (" + (i + 1) + "," + (j + 1) + "):");
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Bottom: " + mat[i + 1, j]);
                        }
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Top: " + mat[i - 1, j]);
                        }
                    }
                }
            }
        }
    }
}