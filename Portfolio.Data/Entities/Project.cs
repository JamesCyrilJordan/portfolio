using System.ComponentModel.DataAnnotations;

namespace Portfolio.Data.Entities
{
	public class Project
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Description { get; set; }
		public string? RepositoryUrl { get; set; }
		public string? LiveDemoUrl { get; set; }
		public string? TechnologiesUsed { get; set; } // Comma-separated list (React, .NET, SQL)
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

		// Foreign Key
		public int UserId { get; set; }

		// Navigation property
		public User User { get; set; }
	}
}
