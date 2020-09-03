
using Domain.Entities;
using MediatR;

namespace Application.BlogPosts.Queries
{
    public class GetBlogPostQuery : IRequest<BlogPost>
    {
        public GetBlogPostQuery(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }
}
