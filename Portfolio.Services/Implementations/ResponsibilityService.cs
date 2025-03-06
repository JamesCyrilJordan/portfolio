using Portfolio.Data.Repositories;
using Portfolio.Services.DTOs;
using Portfolio.Services.Interfaces;

namespace Portfolio.Services.Implementations
{
	public class ResponsibilityService : IResponsibilityService
	{
		private readonly IResponsibilityRepository _repo;

		public ResponsibilityService(IResponsibilityRepository repo)
		{
			_repo = repo;
		}
		public async Task<IEnumerable<ResponsibilityDto>> GetResponsibilitiesByPositionId(int positionId)
		{
			var responsibilities = await _repo.GetResponsibilitiesByPositionId(positionId);
			return responsibilities.Select(r => new ResponsibilityDto
			{
				Description = r.Description,
				Id = r.Id,
				PositionId = r.PositionId
			});
		}
	}
}
