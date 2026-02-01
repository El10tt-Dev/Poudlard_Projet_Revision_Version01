using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Poudlard.Core.Interfaces.Repositories;
using Poudlard.Infrastructure.Database.Context;
using Poudlard.Infrastructure.Repositories;

namespace Poudlard.Infrastructure;

public static class ServiceExtensions
{
    public static IServiceCollection AddInfrastructure (this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<PoudlardContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("Default")));
        
        services.AddScoped<IEleveRepository, EleveRepository>();

        return services;
    }
}
