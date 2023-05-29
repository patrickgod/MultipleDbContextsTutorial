namespace MultipleDbContextsTutorial.Models
{
    public class User
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public List<Character> Characters { get; set; } = new List<Character>();
    }
}
