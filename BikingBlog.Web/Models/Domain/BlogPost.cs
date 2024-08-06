namespace BikingBlog.Web.Models.Domain
{
    public class BlogPost
    {
        public Guid Id { get; set; }
        public string? Heading { get; set; }
        public string? PageTitle { get; set; }
        public string? Content { get; set; }
        public string? Summary { get; set; }
        public string? FeaturedImageUrl { get; set; }
        public string? UrlHandle { get; set;}
        public DateTime PublishedDate { get; set; }
        public string? Auther { get; set; }
        public bool Visible { get; set; }

        // navigation property
        public ICollection<Tag>? Tags { get; set; }
    }
}
