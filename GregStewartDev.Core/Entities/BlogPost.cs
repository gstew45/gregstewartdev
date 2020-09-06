using System;

namespace Domain.Entities
{
    public class BlogPost
    {
        public BlogPost(int? id, string title, string summary, string content, DateTime datePosted)
        {
            Id = id;
            Title = title;
            Summary = summary;
            Content = content;
            DatePosted = datePosted;
        }

        public int? Id { get; }
        public string Title { get; }
        public string Summary { get; }
        public string Content { get; }
        public DateTime DatePosted { get; }
    }
}
