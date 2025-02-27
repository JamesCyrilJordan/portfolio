using Portfolio.Data.Entities;
using Portfolio.Data.Repositories;
using Portfolio.Services.Interfaces;

namespace Portfolio.Services.Implementations
{
    public class ProjectService : IProjectService
    {
		private readonly IProjectRepository _repository;

		public ProjectService(IProjectRepository repository)
		{
			_repository = repository;
		}


		public async Task<IEnumerable<Project>> GetAllProjectsAsync()
		{
			return await _repository.GetAllProjectsAsync();
		}

		public async Task<Project?> GetProjectByIdAsync(int id)
		{
			return await _repository.GetProjectByIdAsync(id);
		}

		public async Task AddProjectAsync(Project project)
		{
			await _repository.AddProjectAsync(project);
			await _repository.SaveChangesAsync();
		}
	}
}
