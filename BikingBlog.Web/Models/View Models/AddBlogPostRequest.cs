using BikingBlog.Web.Models.Domain;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BikingBlog.Web.Models.View_Models
{
    public class AddBlogPostRequest
    {
        public required string Heading { get; set; }
        public required string PageTitle { get; set; }
        public required string Content { get; set; }
        public required string Summary { get; set; }
        public required string FeaturedImageUrl { get; set; }
        public required string UrlHandle { get; set; }
        public DateTime PublishedDate { get; set; }
        public required string Author { get; set; }
        public bool Visible { get; set; }

        // display tags

        public IEnumerable<SelectListItem> Tags { get; set; }

        // collect tags

        public string SelectedTag { get; set; }


    }
}
