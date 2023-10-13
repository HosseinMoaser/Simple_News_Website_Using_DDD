using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RoshanTarAzAftab.Infrastructure.EF;
using RoshanTarAzAftab.Infrastructure.Logging;
using RoshanTarAzAftab.Shared.Abstractions.Commands;
using RoshanTarAzAftab.Shared.Queries;

namespace RoshanTarAzAftab.Infrastructure;

public static class Extensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSQLDB(configuration);
        services.AddQueries();
        services.TryDecorate(typeof(ICommandHandler<>), typeof(LoggingCommandHandlerDecorator<>));
        return services;
    }
}
