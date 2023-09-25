using RoshanTarAzAftab.Application.DTOs;
using RoshanTarAzAftab.Application.Queries.Category;
using RoshanTarAzAftab.Domain.Repositories;
using RoshanTarAzAftab.Shared.Abstractions.Queries;

namespace RoshanTarAzAftab.Application.Queries.Message.Handlers;

public class GetMessageByIdHandler : IQueryHandler<GetMessageById, MessageDto>
{
    private readonly IMessageReporitory _repository;

    public GetMessageByIdHandler(IMessageReporitory repository)
    {
        _repository = repository;
    }

    public async Task<MessageDto> HandleAsync(GetMessageById query)
    {
        var message = await _repository.GetMessageAsync(query.Id);
        // Should be converted to Dto
        return null;
    }
}
