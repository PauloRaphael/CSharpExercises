namespace ExerciseEnumsComposition.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateOnly Date { get; set; }

        public Client(string name, string email, DateOnly date)
        {
            Name = name;
            Email = email;
            Date = date;
        }
    }
}
