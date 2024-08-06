﻿using BikingBlog.Web.Models.Domain;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BikingBlog.Web.Models.View_Models
{
    public class AddBlogPostRequest
    {
        public string? Heading { get; set; }
        public string? PageTitle { get; set; }
        public string? Content { get; set; }
        public string? Summary { get; set; }
        public string? FeaturedImageUrl { get; set; }
        public string? UrlHandle { get; set; }
        public DateTime PublishedDate { get; set; }
        public string? Auther { get; set; }
        public bool Visible { get; set; }

        // display tags

        public IEnumerable<SelectListItem>? Tags { get; set; }

        // collect tags

        public string?[] SelectedTags { get; set; } = Array.Empty<string>();
    }
}
