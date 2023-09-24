using RoshanTarAzAftab.Domain.Entities;
using RoshanTarAzAftab.Domain.ValueObjects;
using RoshanTarAzAftab.Domain.ValueObjects.Message;

namespace RoshanTarAzAftab.Domain.Factories;

public class MessageFactory : IMessageFactory
{
    public Message Create(BaseEntityId id, FullName senderName, Email senderEmail, MessageContent content)
    {
        return new Message(id, senderName, senderEmail, content);
    }
}
