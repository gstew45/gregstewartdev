using Application.BlogPosts.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogPostsController : BaseController
    {
        [HttpGet("getall")]
        public async Task<ActionResult<BlogPostsListViewModel>> GetAll()
        {
            return Ok(await Mediator.Send(new GetBlogPostsListQuery()));
        }
    }
}
