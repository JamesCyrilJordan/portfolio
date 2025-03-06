using Portfolio.Data.Entities;

namespace Portfolio.Data.Repositories
{
	public interface IResponsibilityRepository : IBaseRepository<Responsibility>
	{
		Task<IEnumerable<Responsibility>> GetResponsibilitiesByPositionId(int positionId);
	}
}
