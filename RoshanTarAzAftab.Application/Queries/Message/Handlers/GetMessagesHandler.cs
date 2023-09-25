using RoshanTarAzAftab.Application.DTOs;
using RoshanTarAzAftab.Domain.Repositories;
using RoshanTarAzAftab.Shared.Abstractions.Queries;

namespace RoshanTarAzAftab.Application.Queries.Message.Handlers;

public class GetMessagesHandler : IQueryHandler<GetMessages, IEnumerable<MessageDto>>
{
    private readonly IMessageReporitory _repository;

    public GetMessagesHandler(IMessageReporitory repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<MessageDto>> HandleAsync(GetMessages query)
    {
        var messages = await _repository.GetMessages();
        // Should be converted to dto
        return null;
    }
}
