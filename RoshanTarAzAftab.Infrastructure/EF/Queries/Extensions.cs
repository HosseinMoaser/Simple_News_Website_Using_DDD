using RoshanTarAzAftab.Application.DTOs;
using RoshanTarAzAftab.Infrastructure.EF.Models;

namespace RoshanTarAzAftab.Infrastructure.EF.Queries;

internal static class Extensions
{
    public static PostDto ToPostDto(this PostReadModel post)
    {
        return new PostDto
        {
            Id = post.Id,
            CategoryId= post.CategoryId,
            Content= post.Content,
            DatePosted = post.DatePosted,
            PostType = post.PostType,
            ShortDescription = post.ShortDescription,
            Title = post.Title 
        };
    }

    public static UserDto ToUserDto(this UserReadModel user)
    {
        return new UserDto
        {
            Id = user.Id,
            ActivationCode= user.ActivationCode,
            Email = user.Email,
            FullName = user.FullName,
            IsRegistered = user.IsRegistered
        };
    }

    public static MessageDto ToMessageDto(this MessageReadModel message)
    {
        return new MessageDto
        {
            Id = message.Id,
            Content = message.Content,
            SenderEmail = message.SenderEmail,
            SenderName = message.SenderName
        };
    }

    public static CategoryDto ToCategoryDto(this CategoryReadModel category)
    {
        return new CategoryDto
        {
            Id = category.Id,
            Name = category.Name,
            Posts = category.Posts.Select(p => p.ToPostDto())
        };
    }
}
