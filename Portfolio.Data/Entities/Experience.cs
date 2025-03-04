namespace Portfolio.Data.Entities
{
	public class Experience
	{
		public int Id { get; set; }
		public string Company { get; set; }
		public string Role { get; set; }
		public string Description { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime? EndDate { get; set; } // Nullable if current job
		public bool IsCurrent { get; set; }

		// Foreign Key
		public int UserId { get; set; }

		// Navigation property
		public User User { get; set; }
	}
}
