using Portfolio.Data.Repositories;
using Portfolio.Services.DTOs;
using Portfolio.Services.Interfaces;

namespace Portfolio.Services.Implementations
{
	public class PositionService : IPositionService
	{
		private readonly IPositionRepository _repo;
		public PositionService(IPositionRepository repo)
		{
			_repo = repo;
		}
		public async Task<IEnumerable<PositionDto>> GetAllPositionsAsync()
		{
			var postitions = await _repo.GetAllAsync();
			return postitions.Select(p => new PositionDto
			{
				Id = p.Id,
				Title = p.Title,
				Company = p.Company,
				StartDate = p.StartDate,
				EndDate = p.EndDate,
				Responsibilities = p.Responsibilities.Select(r => new ResponsibilityDto
				{
					Id = r.Id,
					Description = r.Description
				}).ToList()
			});
		}

		public Task<PositionDto> GetPositionByIdAsync(int id)
		{
			throw new NotImplementedException();
		}
	}
}
