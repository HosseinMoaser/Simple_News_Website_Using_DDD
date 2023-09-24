using RoshanTarAzAftab.Domain.Entities;
using RoshanTarAzAftab.Domain.ValueObjects;

namespace RoshanTarAzAftab.Domain.Repositories;

public interface IReplyRepository
{
    Task<Reply> GetCategoryAsync(BaseEntityId id);
    Task AddAsync(Reply reply);
    Task UpdateAsync(Reply reply);
    Task DeleteAsync(Reply reply);
}
