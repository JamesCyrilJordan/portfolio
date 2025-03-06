namespace Portfolio.Services.DTOs
{
    public class ResponsibilityDto
    {
		public int Id { get; set; }
		public required string Description { get; set; }

		public int PositionId { get; set; }

		public PositionDto Position { get; set; }
	}
}
