using BikingBlog.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BikingBlog.Web.Data
{
    public class BlogDbContext: DbContext
    {
        public BlogDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }

        public DbSet<Tag> Tags { get; set; }
    }
}
