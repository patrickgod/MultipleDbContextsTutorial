namespace MultipleDbContextsTutorial.Models
{
    public class Character
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Hitpoints { get; set; }
        public int UserId { get; set; }
    }
}
