using RoshanTarAzAftab.Application.DTOs;
using RoshanTarAzAftab.Shared.Abstractions.Queries;

namespace RoshanTarAzAftab.Application.Queries.User;

public class GetUserById : IQuery<UserDto>
{
    public Guid Id { get; set; }
}
