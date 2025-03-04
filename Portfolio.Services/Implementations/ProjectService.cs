using Portfolio.Data.Entities;
using Portfolio.Data.Repositories;
using Portfolio.Services.DTOs;
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


		public async Task<IEnumerable<ProjectDto>> GetAllProjectsAsync()
		{
			var projects = await _repository.GetAllProjectsAsync();
			return projects.Select(p => new ProjectDto
			{
				Id = p.Id,
				Name = p.Name,
				Description = p.Description,
				RepositoryUrl = p.RepositoryUrl,
				LiveDemoUrl = p.LiveDemoUrl,
				TechnologiesUsed = p.TechnologiesUsed
			}).ToList();
		}

		public async Task<ProjectDto?> GetProjectByIdAsync(int id)
		{
			var project = await _repository.GetProjectByIdAsync(id);
			if (project == null) return null;

			return new ProjectDto
			{
				Id = project.Id,
				Name = project.Name,
				Description = project.Description,
				RepositoryUrl = project.RepositoryUrl,
				LiveDemoUrl = project.LiveDemoUrl,
				TechnologiesUsed = project.TechnologiesUsed
			};
		}

		public async Task AddProjectAsync(ProjectDto projectDto)
		{
			var project = new Project
			{
				Name = projectDto.Name,
				Description = projectDto.Description,
				RepositoryUrl = projectDto.RepositoryUrl,
				LiveDemoUrl = projectDto.LiveDemoUrl,
				TechnologiesUsed = projectDto.TechnologiesUsed
			};

			await _repository.AddProjectAsync(project);
			await _repository.SaveChangesAsync();
		}
	}
}
