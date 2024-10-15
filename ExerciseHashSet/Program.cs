namespace ExerciseHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> cursoA = new HashSet<int>();
            HashSet<int> cursoB = new HashSet<int>();
            HashSet<int> cursoC = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                cursoA.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("How many students for course B? ");
            x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                cursoB.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("How many students for course C? ");
            x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                cursoC.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> students = new HashSet<int>(cursoA.Union(cursoB.Union(cursoC)));

            Console.Write($"Total students: {students.Count()}");

        }
    }
}