using FilmIntegration.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmIntegration.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        public DbSet<Film> Films { get; set; }
    }
}
