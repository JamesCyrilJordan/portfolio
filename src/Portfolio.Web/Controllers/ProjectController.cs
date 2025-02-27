using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Entities;
using Portfolio.Services.Interfaces;

namespace Portfolio.Web.Controllers
{
    public class ProjectController : ControllerBase
    {
		private readonly IProjectService _projectService;

		public ProjectController(IProjectService projectService)
		{
			_projectService = projectService;
		}

		[HttpGet]
		public async Task<IActionResult> GetProjects()
		{
			var projects = await _projectService.GetAllProjectsAsync();
			return Ok(projects);
		}

		[HttpPost]
		public async Task<IActionResult> AddProject(Project project)
		{
			await _projectService.AddProjectAsync(project);
			return CreatedAtAction(nameof(GetProjects), new { id = project.Id }, project);
		}
	}
}
