namespace Portfolio.Services.DTOs
{
	public class ProjectDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string RepositoryUrl { get; set; }
		public string LiveDemoUrl { get; set; }
		public string TechnologiesUsed { get; set; }
	}
}
