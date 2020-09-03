using Domain.Entities;
using System.Collections.Generic;

namespace Application.BlogPosts.Queries
{
    public class BlogPostsListViewModel
    {
        public BlogPostsListViewModel(IList<BlogPost> blogPosts)
        {
            BlogPosts = blogPosts ?? new List<BlogPost>();
        }

        public IList<BlogPost> BlogPosts { get; }
    }
}
