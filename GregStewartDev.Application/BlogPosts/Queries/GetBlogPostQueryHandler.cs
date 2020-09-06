using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.BlogPosts.Queries
{
    public class GetBlogPostQueryHandler : IRequestHandler<GetBlogPostQuery, BlogPost>
    {
        private readonly IBlogStore _blogStore;
        private readonly IMapper _mapper;

        public GetBlogPostQueryHandler(IBlogStore blogStore, IMapper mapper)
        {
            _blogStore = blogStore;
            _mapper = mapper;
        }

        public async Task<BlogPost> Handle(GetBlogPostQuery request, CancellationToken cancellationToken)
        {
            BlogPost blogPost = _blogStore.BlogPosts.First(bp => bp.Id == request.Id);
            return await Task.FromResult(blogPost);
        }
    }
}
