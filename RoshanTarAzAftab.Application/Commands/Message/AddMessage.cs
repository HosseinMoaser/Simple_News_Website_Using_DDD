using RoshanTarAzAftab.Domain.ValueObjects.Message;
using RoshanTarAzAftab.Domain.ValueObjects;
using RoshanTarAzAftab.Shared.Abstractions.Commands;

namespace RoshanTarAzAftab.Application.Commands.Message;

public record AddMessage(BaseEntityId id, FullName senderName, Email senderEmail, MessageContent content) : ICommand;