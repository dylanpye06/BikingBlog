namespace BikingBlog.Web.Models.Domain
{
    public class BlogPost
    {
        public Guid Id { get; set; }
        public required string Heading { get; set; }
        public required string PageTitle { get; set; }
        public required string Content { get; set; }
        public required string Summary { get; set; }
        public required string FeaturedImageUrl { get; set; }
        public required string UrlHandle { get; set;}
        public DateTime PublishedDate { get; set; }
        public required string Auther { get; set; }
        public bool Visible { get; set; }
        public ICollection<Tag>? Tags { get; set; }
    }
}
