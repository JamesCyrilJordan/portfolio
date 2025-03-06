using Portfolio.Data.Repositories;
using Portfolio.Services.DTOs;
using Portfolio.Services.Interfaces;

namespace Portfolio.Services.Implementations
{
	public class ResponsibilityService : IResponsibilityService
	{
		private readonly ResponsibilityRepository _repo;

		public ResponsibilityService(ResponsibilityRepository repo)
		{
			_repo = repo;
		}
		public async Task<IEnumerable<ResponsibilityDto>> GetResponsibilitiesByPositionId(int positionId)
		{
			var responsibilities = await _repo.GetResponsibilitiesByPositionId(positionId);
			//return new ResponsibilityDto
			//{
			//	Description = responsibilities
			//}.To;
			throw new NotImplementedException();
		}
	}
}
