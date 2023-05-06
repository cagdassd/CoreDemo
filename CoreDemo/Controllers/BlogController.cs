using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());

        public IActionResult Index()
        {
            var values = bm.GetAll();
            return View(values);
        }
    }
}
