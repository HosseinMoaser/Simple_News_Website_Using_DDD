using RoshanTarAzAftab.Domain.Common;
using RoshanTarAzAftab.Domain.Enums;
using RoshanTarAzAftab.Domain.Exceptions.Post;
using RoshanTarAzAftab.Domain.ValueObjects;
using RoshanTarAzAftab.Domain.ValueObjects.Category;

namespace RoshanTarAzAftab.Domain.Entities;

public class Category : BaseEntity
{
    private CategoryName _name;
    private readonly LinkedList<Post> _posts = new();

    internal Category(BaseEntityId id, CategoryName name) : base(id)
    {
        _name = name;
    }

    public Category(BaseEntityId id) : base(id)
    {

    }

    private Category(BaseEntityId id, LinkedList<Post> posts) : this(id)
    {
        _posts = posts;
    }

    public void AddPost(Post post)
    {
        var _alreadyExists = _posts.Any(p=> p.Id == post.Id );
        if(_alreadyExists)
        {
            throw new PostAlreadyExistsException(_name);
        }

        _posts.AddLast(post);
    }

    public void AddPosts(IEnumerable<Post> posts)
    {
        foreach(var post in posts)
        {
            AddPost(post);
        }
    }
}
