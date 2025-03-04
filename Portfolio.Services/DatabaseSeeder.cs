using Portfolio.Data;
using Portfolio.Data.Entities;

namespace Portfolio.Services
{
    public class DatabaseSeeder
    {
        private readonly PortfolioDbContext _context;

		public DatabaseSeeder(PortfolioDbContext context)
		{
			_context = context;
		}

		public void Seed()
		{
			_context.Database.EnsureCreated();

			// ✅ Seed Users First
			if (!_context.Users.Any())
			{
				_context.Users.Add(new User
				{
					Id = 1,
					FirstName = "James",
					LastName = "Jordan",
					Email = "james@example.com",
					CreatedAt = DateTime.UtcNow
				});

				_context.SaveChanges();
			}

			// Get the first user
			var user = _context.Users.FirstOrDefault();
			if (user == null) return; // Prevent null errors

			// ✅ Seed Projects After Users
			if (!_context.Projects.Any())
			{
				_context.Projects.AddRange(
					new Project
					{
						Name = "Portfolio Website",
						Description = "A full-stack portfolio showcasing my work and skills.",
						TechnologiesUsed = "React, Vue, Angular, .NET, SQL",
						CreatedAt = DateTime.UtcNow,
						UserId = user.Id // Assign FK correctly
					},
					new Project
					{
						Name = "E-Commerce Platform",
						Description = "An e-commerce site with a custom shopping cart and user authentication.",
						TechnologiesUsed = "Vue, .NET Core, PostgreSQL",
						CreatedAt = DateTime.UtcNow,
						UserId = user.Id // Assign FK correctly
					}
				);

				_context.SaveChanges();
			}
		}
	}
}
