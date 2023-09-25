using RoshanTarAzAftab.Application.Exceptions;
using RoshanTarAzAftab.Domain.Repositories;
using RoshanTarAzAftab.Shared.Abstractions.Commands;

namespace RoshanTarAzAftab.Application.Commands.User.Handlers;

public sealed class RemoveUserHandler : ICommandHandler<RemoveUser>
{
    private readonly IUserRepository _userRepository;

    public RemoveUserHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task HandleAsync(RemoveUser command)
    {
        var user = await _userRepository.GetUserAsync(command.id);
        if(user == null)
        {
            throw new UserNotFoundException();
        }

        await _userRepository.DeleteAsync(user);
    }
}
