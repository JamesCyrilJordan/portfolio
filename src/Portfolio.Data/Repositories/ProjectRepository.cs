using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Entities;

namespace Portfolio.Data.Repositories
{
	public class ProjectRepository : IProjectRepository
	{
		private readonly PortfolioDbContext _context;

		public ProjectRepository(PortfolioDbContext context)
		{
			_context = context;
		}

		public async Task AddProjectAsync(Project project)
		{

			await _context.Projects.AddAsync(project);
		}

		public async Task<IEnumerable<Project>> GetAllProjectsAsync()
		{
			return await _context.Projects.ToListAsync();
		}

		public async Task<Project?> GetProjectByIdAsync(int id)
		{
			return await _context.Projects.FindAsync(id);
		}

		public async Task SaveChangesAsync()
		{
			await _context.SaveChangesAsync();
		}
	}
}
