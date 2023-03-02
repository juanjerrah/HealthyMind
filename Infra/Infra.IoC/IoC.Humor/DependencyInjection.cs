using Data.Humor.Contexts;
using Data.Humor.Repositories;
using Domain.Humor.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IoC.Humor;

public class DependencyInjection
{
    public static IServiceCollection AddServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<HealthyMindDbContext>(opt =>
            opt.UseNpgsql(configuration.GetConnectionString("DbConnection") ?? string.Empty,
                x => x.MigrationsAssembly(typeof(HealthyMindDbContext).Assembly.FullName)));

        services.AddScoped<IHumorRepository, HumorRepository>();

        return services;
    }
}