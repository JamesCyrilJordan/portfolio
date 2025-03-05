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
					},
					new Project
					{
						Name = "E-Commerce Platform",
						Description = "An e-commerce site with a custom shopping cart and user authentication.",
						TechnologiesUsed = "Vue, .NET Core, PostgreSQL",
						CreatedAt = DateTime.UtcNow,
					}
				);

				_context.SaveChanges();
			}
			if (!_context.Positions.Any())
			{
				_context.Positions.AddRange(
					new Position
					{
						Title = "Senior Software Engineer",
						Company = "ACS Technologies",
						StartDate = DateTime.Parse("06/01/2024"),
						EndDate = DateTime.Parse("01/17/2025"),
					},
					new Position
					{
						Title = "Project Lead",
						Company = "Nucor Skyline",
						StartDate = DateTime.Parse("10/01/2019"),
						EndDate = DateTime.Parse("05/01/2020"),
					},
					new Position
					{
						Title = "Senior Software Engineer",
						Company = "Sparc/Booz Allen Hamilton",
						StartDate = DateTime.Parse("03/01/2016"),
						EndDate = DateTime.Parse("07/01/2019"),
					},
					new Position
					{
						Title = "Associate Software Engineer",
						Company = "EmployReward Solutions",
						StartDate = DateTime.Parse("03/01/2012"),
						EndDate = DateTime.Parse("07/01/2016"),
					});
				_context.SaveChanges();
			}

			var position = _context.Positions.FirstOrDefault();
			if (position == null) return; // Prevent null errors

			if (!_context.Responsibilities.Any())
			{
				_context.Responsibilities.AddRange(
					new Responsibility
					{
						Description = "Used full-stack development intranet applications to facilitate call center duties by developing an automated telephone system. The application performs various administrative tasks (i.e., generates mailing lists, faxes, payment requests) automatically",
						PositionId = position.Id
					},
					new Responsibility
					{
						Description = "Worked with several Windows services including; WFC, LDAP (Windows AD), Office Interop, Angular JS, and SSIS",
						PositionId = position.Id
					},
					new Responsibility
					{
						Description = "Proficient usage of ASP.NET in C# and VB, JavaScript (jQuery/Ajax/json), AngularJS, html, css, and sql/t-sql",
						PositionId = position.Id
					},
					new Responsibility
					{
						Description = "Upgraded intranet applications from MVC2 to MVC5 using latest methods of development",
						PositionId = position.Id
					},
					new Responsibility
					{
						Description = "Advised software and hardware needs for office networks and web hosting",
						PositionId = position.Id
					},
					new Responsibility
					{
						Description = "Created responsive, mobile websites using Bootstrap framework",
						PositionId = position.Id
					},
					new Responsibility
					{
						Description = "Utilized Agile methodology",
						PositionId = position.Id
					},
					new Responsibility
					{
						Description = "Reviewed and debugged code",
						PositionId = position.Id
					},
					new Responsibility
					{
						Description = "Responsible for visual interfaces, application logic, database design and web services construction",
						PositionId = position.Id
					},
					new Responsibility
					{
						Description = "Responsible for database/script development and unit testing ",
						PositionId = position.Id
					},
					new Responsibility
					{
						Description = "Involved in the implementation and maintenance of new software development projects",
						PositionId = position.Id
					},
					new Responsibility
					{
						Description = "Created and consulted on new software projects ",
						PositionId = position.Id
					},
					new Responsibility
					{
						Description = "Routinely worked with a variety of applications to provide top quality software solutions for business development",
						PositionId = position.Id
					}
				);
			}
		}
	}
}

