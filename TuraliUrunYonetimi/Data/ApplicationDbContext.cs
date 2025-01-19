using Microsoft.EntityFrameworkCore;

namespace TuraliUrunYonetimi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
        }
        public DbSet<Models.Urun>Uruns { get; set; }
    }
}
