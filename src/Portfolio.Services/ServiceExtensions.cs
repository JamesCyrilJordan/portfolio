using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Portfolio.Data;
using Portfolio.Data.Repositories;
using Portfolio.Services.Implementations;
using Portfolio.Services.Interfaces;

namespace Portfolio.Services;

public static class ServiceExtensions
{
	public static IServiceCollection AddPortfolioServices(this IServiceCollection services, IConfiguration configuration)
	{
		// Register DbContext
		services.AddDbContext<PortfolioDbContext>(x =>
			x.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
		);

		// Register repositories
		services.AddScoped<IProjectRepository, ProjectRepository>();
		services.AddScoped<IUserRepository, UserRepository>();

		// Register services
		services.AddScoped<IProjectService, ProjectService>();
		services.AddScoped<IUserService, UserService>();

		return services;

	}
}
