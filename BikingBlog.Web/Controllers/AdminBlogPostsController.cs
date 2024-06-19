using BikingBlog.Web.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BikingBlog.Web.Controllers
{
    public class AdminBlogPostsController : Controller
    {
        
        private readonly ITagRepository tagRepository1;

         public AdminBlogPostsController(ITagRepository tagRepository)
         {
            this.tagRepository1 = tagRepository;
         }



        [HttpGet]
        public IActionResult AddBlogPost()
        {
            //get tags from repository

            return View();
        }
            
        
    }
}
