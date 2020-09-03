using MediatR;

namespace Application.BlogPosts.Queries
{
    public class GetBlogPostsListQuery : IRequest<BlogPostsListViewModel>
    {
    }
}
