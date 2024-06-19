namespace BikingBlog.Web.Models.View_Models
{
    public class EditTagRequest
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string DisplayName { get; set; }
    }
}
