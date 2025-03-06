using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Entities;

namespace Portfolio.Data.Repositories
{
    public class ResponsibilityRepository : BaseRepository<Responsibility>, IResponsibilityRepository
    {

		public ResponsibilityRepository(PortfolioDbContext context) : base(context)
		{
		}

		public async Task<IEnumerable<Responsibility>> GetResponsibilitiesByPositionId(int positionId)
		{
			return await _context.Responsibilities.Where(x => x.PositionId == positionId).ToListAsync();
		}
	}
}
