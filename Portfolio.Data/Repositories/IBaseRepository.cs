using System.Linq.Expressions;

namespace Portfolio.Data.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
		Task<T?> GetByIdAsync(int id);
		Task<IEnumerable<T>> GetAllAsync();
		Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
		Task<PagedResult<T>> GetPagedAsync(int pageNumber, int pageSize, Expression<Func<T, bool>>? filter = null, Expression<Func<T, object>>? orderBy = null, bool ascending = true);
		Task AddAsync(T entity);
		Task AddRangeAsync(IEnumerable<T> entities);
		Task UpdateAsync(T entity);
		Task DeleteAsync(T entity);
		Task DeleteByIdAsync(int id);
		Task<int> SaveChangesAsync();
	}
}
