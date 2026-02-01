using Microsoft.Extensions.DependencyInjection;

namespace Poudlard.Core;

public static class ServiceExtensions
{
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        return services;
    }
}
