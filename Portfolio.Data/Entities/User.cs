using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Data.Entities
{
	public class User
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string? Bio { get; set; }
		public string? ProfilePictureUrl { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

		// Navigation properties
		public ICollection<Project> Projects { get; set; } = new List<Project>();
		public ICollection<Experience> Experiences { get; set; } = new List<Experience>();
	}
}
