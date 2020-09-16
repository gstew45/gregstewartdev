using Application.Interfaces;
using Domain.Entities;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Infrastructure
{
    public class FileBlogStore : IBlogStore
    {
        private const string BlogPostsPath = @".\wwwroot\blogposts";
        public FileBlogStore()
        {
            BlogPosts = new List<BlogPost>();
        }

        public IList<BlogPost> BlogPosts { get; }

        public void Initalize()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            bool directoryExists = Directory.Exists(BlogPostsPath);
            if (!directoryExists)
                return;

            string[] blogs = Directory.GetFiles(BlogPostsPath, "*.json");
            foreach (string blog in blogs)
            {
                using (StreamReader r = new StreamReader(blog))
                {
                    string json = r.ReadToEnd();
                    BlogPost blogPost = JsonConvert.DeserializeObject<BlogPost>(json);

                    BlogPosts.Add(blogPost);
                }
            }
        }
    }
}
