namespace RoshanTarAzAftab.Infrastructure.EF.Models;

public class UserReadModel
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string ActivationCode { get; set; }
    public bool IsRegistered { get; set; }
}
