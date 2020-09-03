namespace Domain.Entities
{
    public class BlogPost
    {
        public BlogPost(string title, string content)
        {
            Title = title;
            Content = content;
        }

        public string Title { get; }
        public string Content { get; }
    }
}
