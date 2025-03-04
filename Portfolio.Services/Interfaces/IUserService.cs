using Portfolio.Data.Entities;

namespace Portfolio.Services.Interfaces
{
	public interface IUserService
	{
		Task<IEnumerable<User>> GetAllUsersAsync();
		Task<User?> GetUserByIdAsync(int id);
		Task AddUserAsync(User user);
	}
}
