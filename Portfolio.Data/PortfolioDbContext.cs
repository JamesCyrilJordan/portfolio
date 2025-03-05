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

		public DbSet<Project> Projects { get; set; }
		public DbSet<Position> Positions { get; set; }
		public DbSet<Responsibility> Responsibilities { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Responsibility>()
				.HasOne(p => p.Position)
				.WithMany(r => r.Responsibilities)
				.HasForeignKey(x => x.PositionId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
