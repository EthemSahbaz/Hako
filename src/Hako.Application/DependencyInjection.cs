using Hako.Application.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Hako.Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddSingleton<IGameRepository, GameRepository>();

        return services;
    }
}
