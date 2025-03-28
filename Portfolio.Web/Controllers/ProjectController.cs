using Microsoft.AspNetCore.Mvc;
using Portfolio.Services.Interfaces;
using Portfolio.Services.DTOs;

namespace Portfolio.Web.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
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

		[HttpGet("{id}")]
		public async Task<IActionResult> GetProject(int id)
		{
			var project = await _projectService.GetProjectByIdAsync(id);
			if (project == null) return NotFound();

			return Ok(project);
		}

		[HttpPost]
		public async Task<IActionResult> AddProject(ProjectDto projectDto)
		{
			if (projectDto == null) return BadRequest("Invalid project data");

			await _projectService.AddProjectAsync(projectDto);
			return CreatedAtAction(nameof(GetProjects), new { }, projectDto);
		}
	}
}
