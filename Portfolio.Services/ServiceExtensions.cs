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
		services.AddDbContext<PortfolioDbContext>(options =>
			options.UseSqlServer(
			configuration.GetConnectionString("DefaultConnection"),
			sqlOptions => sqlOptions.MigrationsAssembly("Portfolio.Data") // Ensures migrations are generated in Portfolio.Data
		));

		// Register repositories
		services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
		services.AddScoped<IProjectRepository, ProjectRepository>();
		services.AddScoped<IPositionRepository, PositionRepository>();
		services.AddScoped<IResponsibilityRepository, ResponsibilityRepository>();

		// Register services
		services.AddScoped<IProjectService, ProjectService>();

		services.AddScoped<DatabaseSeeder>(); // Register DatabaseSeeder


		return services;

	}
}
