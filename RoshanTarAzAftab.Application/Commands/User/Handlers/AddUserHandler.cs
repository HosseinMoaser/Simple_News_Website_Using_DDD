using RoshanTarAzAftab.Domain.Factories;
using RoshanTarAzAftab.Domain.Repositories;
using RoshanTarAzAftab.Shared.Abstractions.Commands;

namespace RoshanTarAzAftab.Application.Commands.User.Handlers;

public sealed class AddUserHandler : ICommandHandler<AddUser>
{
    private readonly IUserRepository _userRepository;
    private readonly IUserFactory _userFactory;

    public AddUserHandler(IUserRepository userRepository, IUserFactory userFactory)
    {
        _userRepository = userRepository;
        _userFactory = userFactory;
    }

    public async Task HandleAsync(AddUser command)
    {
        var user = _userFactory.Create(command.id,command.email,command.activationCode,command.isRegistered);
        await _userRepository.AddAsync(user);
    }
}
