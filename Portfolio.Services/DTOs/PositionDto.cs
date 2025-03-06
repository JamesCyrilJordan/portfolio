namespace Portfolio.Services.DTOs
{
    public class PositionDto
    {
		public int Id { get; set; }
		public required string Title { get; set; }
		public required string Company { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
	}
}
