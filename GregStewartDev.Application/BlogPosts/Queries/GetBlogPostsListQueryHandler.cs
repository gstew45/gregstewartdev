using Application.Interfaces;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.BlogPosts.Queries
{
    public class GetBlogPostsListQueryHandler : IRequestHandler<GetBlogPostsListQuery, BlogPostsListViewModel>
    {
        private readonly IBlogStore _blogStore;
        private readonly IMapper _mapper;

        public GetBlogPostsListQueryHandler(IBlogStore blogStore, IMapper mapper)
        {
            _blogStore = blogStore;
            _mapper = mapper;
        }

        public async Task<BlogPostsListViewModel> Handle(GetBlogPostsListQuery request, CancellationToken cancellationToken)
        {
            BlogPostsListViewModel blogPostsListViewModel = new BlogPostsListViewModel(_blogStore.BlogPosts);
            return await Task.FromResult(blogPostsListViewModel);
        }
    }
}
