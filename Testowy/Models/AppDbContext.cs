
using Microsoft.EntityFrameworkCore;

namespace Testowy.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        {
        }
    }
}
