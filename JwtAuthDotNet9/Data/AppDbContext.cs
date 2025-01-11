using JwtAuthDotNet9.Models;
using Microsoft.EntityFrameworkCore;

namespace JwtAuthDotNet9.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
    }
}
