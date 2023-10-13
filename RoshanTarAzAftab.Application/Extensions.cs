using Microsoft.Extensions.DependencyInjection;
using RoshanTarAzAftab.Domain.Factories;
using RoshanTarAzAftab.Shared.Commands;

namespace RoshanTarAzAftab.Application;

public static class Extensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddCommands();
        services.AddSingleton<ICategoryFactory, CategoryFactory>();
        services.AddSingleton<IMessageFactory, MessageFactory>();
        services.AddSingleton<IUserFactory, UserFactory>();
        services.AddSingleton<IPostFactory, PostFactory>();


        return services;
    }
}
