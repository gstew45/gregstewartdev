using Application.Interfaces;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace WebUI.Pages
{
    public class BlogPostPageBase : ComponentBase
    {
        [Inject]
        public IBlogPostService BlogService { get; set; }

        [Parameter]
        public string BlogPostId { get; set; }

        public Domain.Entities.BlogPost BlogPost { get; private set; }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            BlogPost = await BlogService.GetBlogPost(int.Parse(BlogPostId));
        }

    }
}
