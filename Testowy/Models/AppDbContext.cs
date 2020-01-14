
using Microsoft.EntityFrameworkCore;

namespace Testowy.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }

        public DbSet<Samochod> samochody { get; set; }
        public DbSet<Opinia> opinie { get; set; }
    }
}
