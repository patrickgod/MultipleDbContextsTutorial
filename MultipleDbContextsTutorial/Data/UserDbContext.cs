using Microsoft.EntityFrameworkCore;
using MultipleDbContextsTutorial.Models;

namespace MultipleDbContextsTutorial.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options)
        : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
