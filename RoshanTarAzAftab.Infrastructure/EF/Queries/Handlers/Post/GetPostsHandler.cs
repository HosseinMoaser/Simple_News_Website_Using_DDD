﻿using RoshanTarAzAftab.Application.DTOs;
using RoshanTarAzAftab.Application.Queries.Category;
using RoshanTarAzAftab.Application.Queries.Post;
using RoshanTarAzAftab.Domain.Repositories;
using RoshanTarAzAftab.Shared.Abstractions.Queries;

namespace RoshanTarAzAftab.Infrastructure.EF.Queries.Handlers.Post;

public class GetPostsHandler : IQueryHandler<GetPosts, IEnumerable<PostDto>>
{
    private readonly IPostRepository _repository;

    public GetPostsHandler(IPostRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<PostDto>> HandleAsync(GetPosts query)
    {
        var posts = await _repository.GetPosts();
        // should be converted to dto
        return null;
    }
}