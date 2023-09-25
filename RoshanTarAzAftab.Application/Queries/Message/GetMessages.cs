using RoshanTarAzAftab.Application.DTOs;
using RoshanTarAzAftab.Shared.Abstractions.Queries;

namespace RoshanTarAzAftab.Application.Queries.Message;

public class GetMessages : IQuery<IEnumerable<MessageDto>>
{
}
