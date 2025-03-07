using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Entities;

namespace Portfolio.Data.Repositories
{
    public class PositionRepository : BaseRepository<Position>, IPositionRepository
    {
		public PositionRepository(PortfolioDbContext context) : base(context)
		{			
		}

		public async Task<IEnumerable<Position>> GetAllPositionsAndResponsibilitiesAsync()
		{
			return await _context.Positions
				.Include(p => p.Responsibilities)
				.ToListAsync();
		}
	}
}
