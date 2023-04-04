using Microsoft.EntityFrameworkCore;
using SophiaApp.Models;

namespace SophiaApp.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Slider> Sliders { get; set; }
    }
}
