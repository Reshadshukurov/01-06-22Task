using Blink.Models;
using Microsoft.EntityFrameworkCore;

namespace Blink.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        { }
        public DbSet<News> News { get; set; }
    }
}
