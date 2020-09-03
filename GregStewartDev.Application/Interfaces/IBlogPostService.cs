using Application.BlogPosts.Queries;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IBlogPostService
    {
        Task<BlogPostsListViewModel> GetAllBlogPosts();
    }
}
