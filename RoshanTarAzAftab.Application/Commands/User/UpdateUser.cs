using RoshanTarAzAftab.Domain.ValueObjects.Message;
using RoshanTarAzAftab.Domain.ValueObjects;
using RoshanTarAzAftab.Shared.Abstractions.Commands;

namespace RoshanTarAzAftab.Application.Commands.User;

public record UpdateUser(BaseEntityId id, Email email, ActivationCode activationCode,bool isRegistered) : ICommand;
