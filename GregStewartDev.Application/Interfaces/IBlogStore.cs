using Domain.Entities;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface IBlogStore
    {
        IList<BlogPost> BlogPosts { get; }
    }
}
