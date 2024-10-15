namespace ExerciseCollections
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> VotesPerCandidate = new Dictionary<string, int>();

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            try
            {

                using (StreamReader sr = File.OpenText(path))
                {
                    while(!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(';');

                        if (VotesPerCandidate.ContainsKey(line[0])) {
                            VotesPerCandidate[line[0]] += int.Parse(line[1]);
                        } else
                        {
                            VotesPerCandidate[line[0]] = int.Parse(line[1]);
                        }       
                    }
                }

                foreach(KeyValuePair<String, int> item in VotesPerCandidate) {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }

            } catch (IOException ex) {
                Console.WriteLine($"There was an error: {ex.Message}");
            }
        }
    }
}