using Portfolio.Data.Entities;

namespace Portfolio.Data.Repositories
{
	public interface IProjectRepository
	{
		Task<IEnumerable<Project>> GetAllProjectsAsync();
		Task<Project?> GetProjectByIdAsync(int id);
		Task AddProjectAsync(Project project);
		Task SaveChangesAsync();
	}
}
