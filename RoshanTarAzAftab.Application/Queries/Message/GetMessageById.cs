using RoshanTarAzAftab.Application.DTOs;
using RoshanTarAzAftab.Shared.Abstractions.Queries;

namespace RoshanTarAzAftab.Application.Queries.Message;

public class GetMessageById : IQuery<MessageDto>
{
    public Guid Id { get; set; }
}
