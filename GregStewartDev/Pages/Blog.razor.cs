using Application.BlogPosts.Queries;
using Application.Interfaces;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace WebUI.Pages
{
    public class BlogBase : ComponentBase
    {
        [Inject]
        public IBlogPostService BlogPostService { get; set; }

		public BlogPostsListViewModel ViewModel { get; set; }

		protected override async Task OnInitializedAsync()
		{
			await base.OnInitializedAsync();
			ViewModel = await BlogPostService.GetAllBlogPosts();
		}
	}
}
