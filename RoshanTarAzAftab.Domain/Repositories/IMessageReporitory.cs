using RoshanTarAzAftab.Domain.Entities;
using RoshanTarAzAftab.Domain.ValueObjects;

namespace RoshanTarAzAftab.Domain.Repositories;

public interface IMessageReporitory
{
    Task<Message> GetCategoryAsync(BaseEntityId id);
    Task AddAsync(Message message);
    Task UpdateAsync(Message message);
    Task DeleteAsync(Message message);
}
