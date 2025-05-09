namespace CodePulse.api.Models.Domain
{
    public class BlogPost
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string Content { get; set; }
        public string FeatureImageUrl { get; set; }
        public string UrlHandle { get; set; }
        public DateTime PublishDate { get; set; }
        public string Author { get; set; }
        public string IsVisible { get; set; }

    }
}
