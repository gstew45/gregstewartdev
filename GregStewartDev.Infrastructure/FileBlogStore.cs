using Application.Interfaces;
using Domain.Entities;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Infrastructure
{
    public class FileBlogStore : IBlogStore
    {
        public FileBlogStore()
        {
            BlogPosts = new List<BlogPost>();
        }

        public IList<BlogPost> BlogPosts { get; }

        public void Initalize()
        {
            using (StreamReader r = new StreamReader(@"C:\Dev\GregStewartDev\TestBlogPosts\testblog.json"))
            {
                string json = r.ReadToEnd();
                BlogPost blogPost = JsonConvert.DeserializeObject<BlogPost>(json);

                BlogPosts.Add(blogPost);
            }
        }
    }
}
