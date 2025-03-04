using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Entities;

namespace Portfolio.Data.Repositories
{
	public class UserRepository : IUserRepository
	{
		private readonly PortfolioDbContext _context;

		public UserRepository(PortfolioDbContext context)
		{
			_context = context;			
		}

		public async Task AddUserAsync(User user)
		{
			await _context.Users.AddAsync(user);
		}

		public async Task<IEnumerable<User>> GetAllUsersAsync()
		{
			return await _context.Users.ToListAsync();
		}

		public async Task<User?> GetUserByIdAsync(int id)
		{
			return await _context.Users.FindAsync(id);
		}

		public async Task SaveChangesAsync()
		{
			await _context.SaveChangesAsync();
		}
	}
}
