using RoshanTarAzAftab.Application.DTOs;
using RoshanTarAzAftab.Shared.Abstractions.Queries;

namespace RoshanTarAzAftab.Application.Queries.Post;

public class GetPostById : IQuery<PostDto>
{
    public Guid Id { get; set; }
}
