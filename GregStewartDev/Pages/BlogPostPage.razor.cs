using Application.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace WebUI.Pages
{
    public class BlogPostPageBase : ComponentBase
    {
        [Inject]
        public IBlogPostService BlogService { get; set; }

        [Parameter]
        public string BlogPostId { get; set; }

        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        public Domain.Entities.BlogPost BlogPost { get; private set; }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            BlogPost = await BlogService.GetBlogPost(int.Parse(BlogPostId));
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await JSRuntime.InvokeVoidAsync("Prism.highlightAll");
        }
    }
}
