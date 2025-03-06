using Portfolio.Services.DTOs;
using Portfolio.Services.Interfaces;

namespace Portfolio.Services.Implementations
{
	public class PositionService : IPositionService
	{
		public Task<IEnumerable<PositionDto>> GetAllPositionsAsync()
		{
			throw new NotImplementedException();
		}

		public Task<PositionDto> GetPositionByIdAsync(int id)
		{
			throw new NotImplementedException();
		}
	}
}
