﻿using BikingBlog.Web.Models.Domain;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BikingBlog.Web.Models.View_Models
{
    public class EditBlogPostRequest
    {
        public Guid Id { get; set; }
        public string? Heading { get; set; }
        public string? PageTitle { get; set; }
        public string? Content { get; set; }
        public string? Summary { get; set; }
        public string? FeaturedImageUrl { get; set; }
        public string? UrlHandle { get; set; }
        public DateTime PublishedDate { get; set; }
        public string? Auther { get; set; }
        public bool Visible { get; set; }
        public IEnumerable<SelectListItem>? Tags { get; set; }
        public string?[] SelectedTags { get; set; } = Array.Empty<string>();
    }
}
