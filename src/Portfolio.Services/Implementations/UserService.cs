using Portfolio.Data.Entities;
using Portfolio.Services.Interfaces;
using Portfolio.Data.Repositories;

namespace Portfolio.Services.Implementations
{
    public class UserService : IUserService
    {
		private readonly IUserRepository _repository;

		public UserService(IUserRepository repository)
		{
			_repository = repository;
		}

		public async Task AddUserAsync(User user)
		{
			await _repository.AddUserAsync(user);
			await _repository.SaveChangesAsync();
		}

		public async Task<IEnumerable<User>> GetAllUsersAsync()
		{
			return await _repository.GetAllUsersAsync();
		}

		public async Task<User?> GetUserByIdAsync(int id)
		{
			return await _repository.GetUserByIdAsync(id);
		}
	}
}
