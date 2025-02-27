using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Entities;

namespace Portfolio.Data
{
	public class PortfolioDbContext : DbContext
	{
		public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options)
			: base(options)
		{
		}

		public DbSet<User> Users { get; set; }
		public DbSet<Project> Projects { get; set; }
		public DbSet<Experience> Experiences { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// User-Project Relationship
			modelBuilder.Entity<Project>()
				.HasOne(p => p.User)
				.WithMany(u => u.Projects)
				.HasForeignKey(p => p.UserId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<Experience>()
				.HasOne(e => e.User)
				.WithMany(u => u.Experiences)
				.HasForeignKey(p => p.UserId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
