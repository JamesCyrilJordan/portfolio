namespace Portfolio.Data.Entities
{
    public class Responsibility
    {
		public int Id { get; set; }
		public required string Description { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

		public int PositionId { get; set; }

		public Position Position { get; set; }
	}
}
