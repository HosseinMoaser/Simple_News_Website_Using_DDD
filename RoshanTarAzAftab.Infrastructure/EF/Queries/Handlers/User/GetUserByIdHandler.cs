using RoshanTarAzAftab.Application.DTOs;
using RoshanTarAzAftab.Application.Queries.User;
using RoshanTarAzAftab.Domain.Repositories;
using RoshanTarAzAftab.Shared.Abstractions.Queries;

namespace RoshanTarAzAftab.Infrastructure.EF.Queries.Handlers.User;

public class GetUserByIdHandler : IQueryHandler<GetUserById, UserDto>
{
    private readonly IUserRepository _repository;

    public GetUserByIdHandler(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task<UserDto> HandleAsync(GetUserById query)
    {
        var user = await _repository.GetUserAsync(query.Id);
        // Should be comnverted to dto
        return null;
    }
}
