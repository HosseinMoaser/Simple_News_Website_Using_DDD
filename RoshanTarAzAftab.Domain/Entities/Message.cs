using RoshanTarAzAftab.Domain.Common;
using RoshanTarAzAftab.Domain.ValueObjects;
using RoshanTarAzAftab.Domain.ValueObjects.Message;

namespace RoshanTarAzAftab.Domain.Entities;

public class Message : BaseEntity
{
    private FullName _senderName;
    private Email _senderEmail;
    private MessageContent _content;

    internal Message(BaseEntityId id,FullName senderName, Email senderEmail, MessageContent content) : base(id)
    {
        _senderName = senderName;
        _senderEmail = senderEmail;
        _content = content;
    }

    public Message(BaseEntityId id): base(id)
    {

    }
}
