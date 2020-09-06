namespace Domain.Entities
{
    public class BlogPost
    {
        public BlogPost(int? id, string title, string summary, string content)
        {
            Id = id;
            Title = title;
            Summary = summary;
            Content = content;
        }

        public int? Id { get; }
        public string Title { get; }
        public string Summary { get; }
        public string Content { get; }
    }
}
