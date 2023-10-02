using Microsoft.EntityFrameworkCore;
using RoshanTarAzAftab.Application.DTOs;
using RoshanTarAzAftab.Application.Queries.User;
using RoshanTarAzAftab.Domain.Repositories;
using RoshanTarAzAftab.Infrastructure.EF.Context;
using RoshanTarAzAftab.Infrastructure.EF.Models;
using RoshanTarAzAftab.Shared.Abstractions.Queries;

namespace RoshanTarAzAftab.Infrastructure.EF.Queries.Handlers.User;

internal class GetUsersHandler : IQueryHandler<GetUsers, IEnumerable<UserDto>>
{
    private readonly DbSet<UserReadModel> _users;

    public GetUsersHandler(ReadDbContext readContext)
    {
        _users = readContext.User;
    }

    public async Task<IEnumerable<UserDto>> HandleAsync(GetUsers query)
    {
        return await _users.Select(u=> u.ToUserDto()).ToListAsync();
    }
}
