using James_Jordan_Portfolio.Models;
using Microsoft.EntityFrameworkCore;

namespace James_Jordan_Portfolio.Data
{
    public class PortfolioDbContext : DbContext
    {
        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        //public DbSet<Experience> Experiences { get; set; }
    }
}
