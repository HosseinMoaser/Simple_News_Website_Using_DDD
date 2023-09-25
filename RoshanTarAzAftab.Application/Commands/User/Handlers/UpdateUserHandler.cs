using RoshanTarAzAftab.Application.Exceptions;
using RoshanTarAzAftab.Domain.Factories;
using RoshanTarAzAftab.Domain.Repositories;
using RoshanTarAzAftab.Shared.Abstractions.Commands;

namespace RoshanTarAzAftab.Application.Commands.User.Handlers;

public sealed class UpdateUserHandler : ICommandHandler<UpdateUser>
{
    private readonly IUserRepository _userRepository;
    private readonly IUserFactory _userFactory;

    public UpdateUserHandler(IUserRepository userRepository, IUserFactory userFactory)
    {
        _userRepository = userRepository;
        _userFactory = userFactory;
    }

    public async Task HandleAsync(UpdateUser command)
    {
        var user = await _userRepository.GetUserAsync(command.id);
        if (user == null)
        {
            throw new UserNotFoundException();
        }
        // Activation Code Should be changed 
        var updatedUser = _userFactory.Create(command.id,command.email,command.activationCode,command.isRegistered);
        await _userRepository.UpdateAsync(updatedUser);
    }
}
