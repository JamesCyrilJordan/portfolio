using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Entities;

namespace Portfolio.Data.Repositories
{
	public class ProjectRepository : BaseRepository<Project>, IProjectRepository
	{
		public ProjectRepository(PortfolioDbContext context) : base(context)
		{
		}		
	}
}
