using Application.BlogPosts.Queries;
using Domain.Entities;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IBlogPostService
    {
        Task<BlogPostsListViewModel> GetAllBlogPosts();
        Task<BlogPost> GetBlogPost(int id);
    }
}
