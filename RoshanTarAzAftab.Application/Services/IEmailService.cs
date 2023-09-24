using RoshanTarAzAftab.Domain.ValueObjects.Message;

namespace RoshanTarAzAftab.Application.Services;

public interface IEmailService
{
    Task SendEmailAsync(Email email,string message);
}
