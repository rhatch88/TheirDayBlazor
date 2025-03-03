using Microsoft.EntityFrameworkCore;

namespace TheirDayBlazor.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<TheirDayBlazor.Models.Event> Events { get; set; }
    }
}
