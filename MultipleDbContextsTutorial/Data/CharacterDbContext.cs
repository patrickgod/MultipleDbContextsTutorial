using Microsoft.EntityFrameworkCore;
using MultipleDbContextsTutorial.Models;

namespace MultipleDbContextsTutorial.Data
{
    public class CharacterDbContext : DbContext
    {
        public CharacterDbContext(DbContextOptions<CharacterDbContext> options)
        : base(options)
        {
        }

        public DbSet<Character> Characters { get; set; }
    }
}
