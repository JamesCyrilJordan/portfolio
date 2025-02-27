using Portfolio.Data.Entities;


namespace Portfolio.Services.Interfaces
{
    public interface IProjectService
    {
		Task<IEnumerable<Project>> GetAllProjectsAsync();
		Task<Project?> GetProjectByIdAsync(int id);
		Task AddProjectAsync(Project project);
	}
}
