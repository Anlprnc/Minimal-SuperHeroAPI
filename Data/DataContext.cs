using Microsoft.EntityFrameworkCore;
using SuperHeroAPI.Entities;

namespace SuperHeroAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> option)
            : base(option) { }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
