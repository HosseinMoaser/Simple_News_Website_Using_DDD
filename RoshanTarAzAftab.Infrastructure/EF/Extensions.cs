using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RoshanTarAzAftab.Application.Services;
using RoshanTarAzAftab.Domain.Repositories;
using RoshanTarAzAftab.Infrastructure.EF.Context;
using RoshanTarAzAftab.Infrastructure.EF.Options;
using RoshanTarAzAftab.Infrastructure.EF.Repositories;
using RoshanTarAzAftab.Infrastructure.EF.Services;
using RoshanTarAzAftab.Shared.Options;

namespace RoshanTarAzAftab.Infrastructure.EF;

internal static class Extensions
{
    public static IServiceCollection AddSQLDB(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IMessageReporitory, MessageRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IPostRepository, PostRepository>();
        services.AddScoped<IPostReadService, PostReadService>();

        var options = configuration.GetOptions<DataBaseOptions>("DataBaseConnectionString");
        services.AddDbContext<ReadDbContext>(ctx =>
        ctx.UseSqlServer(options.ConnectionString));
        services.AddDbContext<WriteDbContext>(ctx =>
            ctx.UseSqlServer(options.ConnectionString));

        return services;
    }
}
