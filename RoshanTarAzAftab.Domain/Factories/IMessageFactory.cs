using RoshanTarAzAftab.Domain.Entities;
using RoshanTarAzAftab.Domain.ValueObjects.Message;
using RoshanTarAzAftab.Domain.ValueObjects;

namespace RoshanTarAzAftab.Domain.Factories;

public interface IMessageFactory
{
    Message Create(BaseEntityId id, FullName senderName, Email senderEmail, MessageContent content);
}
