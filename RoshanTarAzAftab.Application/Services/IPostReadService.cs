using RoshanTarAzAftab.Application.DTOs;

namespace RoshanTarAzAftab.Application.Services;

public interface IPostReadService
{
    Task<IEnumerable<PostDto>> ReadPostsAsync();
}
