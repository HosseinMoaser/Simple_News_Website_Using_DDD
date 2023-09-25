using RoshanTarAzAftab.Application.Exceptions;
using RoshanTarAzAftab.Domain.Factories;
using RoshanTarAzAftab.Domain.Repositories;
using RoshanTarAzAftab.Shared.Abstractions.Commands;

namespace RoshanTarAzAftab.Application.Commands.Message.Handlers;

public sealed class UpdateMessageHandler : ICommandHandler<UpdateMessage>
{
    private readonly IMessageReporitory _messageRepository;
    private readonly IMessageFactory _messageFactory;

    public UpdateMessageHandler(IMessageReporitory messageRepository, IMessageFactory messageFactory)
    {
        _messageRepository = messageRepository;
        _messageFactory = messageFactory;
    }

    public async Task HandleAsync(UpdateMessage command)
    {
        var message = await _messageRepository.GetMessageAsync(command.id);

        if (message == null)
        {
            throw new MessageNotFoundException();
        }

        var updatedMessage = _messageFactory.Create(command.id,command.senderName,command.senderEmail,command.content);
        await _messageRepository.UpdateAsync(updatedMessage);
    }
}
