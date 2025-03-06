using Portfolio.Services.DTOs;

namespace Portfolio.Services.Interfaces
{
    public interface IProjectService
    {
		Task<IEnumerable<ProjectDto>> GetAllProjectsAsync();
		Task<ProjectDto?> GetProjectByIdAsync(int id);
		Task AddProjectAsync(ProjectDto project);
	}
}
