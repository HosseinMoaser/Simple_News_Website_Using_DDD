using RoshanTarAzAftab.Application.DTOs;
using RoshanTarAzAftab.Domain.Entities;
using RoshanTarAzAftab.Shared.Abstractions.Queries;

namespace RoshanTarAzAftab.Application.Queries.User;

public class GetUsers : IQuery<IEnumerable<UserDto>>
{
}
