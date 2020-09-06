using Application.BlogPosts.Queries;
using Application.Interfaces;
using Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebUI.Services
{
    public class BlogPostService : IBlogPostService
    {
        private readonly HttpClient _httpClient;

        public BlogPostService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

		public async Task<BlogPostsListViewModel> GetAllBlogPosts()
		{
            using (HttpResponseMessage response = await _httpClient.GetAsync("blogposts/getall"))
            {
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        string payloadReceived = content.ReadAsStringAsync().Result;
                        return JsonConvert.DeserializeObject<BlogPostsListViewModel>(payloadReceived);
                    }
                }
                else
                {
                    throw new Exception($"Error ({response.StatusCode})");
                }
            }

            throw new NotImplementedException();
		}

        public async Task<BlogPost> GetBlogPost(int id)
        {
            using (HttpResponseMessage response = await _httpClient.GetAsync($"blogposts/{id}"))
            {
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        string payloadReceived = content.ReadAsStringAsync().Result;
                        return JsonConvert.DeserializeObject<BlogPost>(payloadReceived);
                    }
                }
                else
                {
                    throw new Exception($"Error ({response.StatusCode})");
                }
            }

            throw new NotImplementedException();
        }
    }
}
