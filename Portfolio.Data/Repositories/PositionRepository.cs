using Portfolio.Data.Entities;

namespace Portfolio.Data.Repositories
{
    public class PositionRepository : BaseRepository<Position>, IPositionRepository
    {
		public PositionRepository(PortfolioDbContext context) : base(context)
		{			
		}
	}
}
