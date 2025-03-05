namespace Portfolio.Data.Entities
{
    public class Position
    {
		public int Id { get; set; }
		public required string Title { get; set; }
		public required string Company { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

		public ICollection<Responsibility> Responsibilities { get; set; } = new List<Responsibility>();
	}
}
