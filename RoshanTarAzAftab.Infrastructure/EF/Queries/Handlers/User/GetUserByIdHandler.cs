using Microsoft.EntityFrameworkCore;
using RoshanTarAzAftab.Application.DTOs;
using RoshanTarAzAftab.Application.Queries.User;
using RoshanTarAzAftab.Domain.Entities;
using RoshanTarAzAftab.Infrastructure.EF.Context;
using RoshanTarAzAftab.Infrastructure.EF.Models;
using RoshanTarAzAftab.Shared.Abstractions.Queries;

namespace RoshanTarAzAftab.Infrastructure.EF.Queries.Handlers.User;

internal class GetUserByIdHandler : IQueryHandler<GetUserById, UserDto>
{
    private readonly DbSet<UserReadModel> _users;

    public GetUserByIdHandler(ReadDbContext readContext)
    {
        _users = readContext.User;
    }

    public async Task<UserDto> HandleAsync(GetUserById query)
    {
        var user = await _users.Where(u => u.Id == query.Id)
           .Select(u => u.ToPostDto())
           .AsNoTracking()
           .SingleOrDefaultAsync();
        return user;
    }
}
