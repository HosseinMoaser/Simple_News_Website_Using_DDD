using RoshanTarAzAftab.Application.DTOs;
using RoshanTarAzAftab.Shared.Abstractions.Queries;

namespace RoshanTarAzAftab.Application.Queries.Post;

public class GetPosts : IQuery<IEnumerable<PostDto>>
{
    public List<PostDto> Posts { get; set; }
}
