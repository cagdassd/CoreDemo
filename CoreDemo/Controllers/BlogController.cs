using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager cm = new BlogManager(new EfBlogRepository());

        public IActionResult Index()
        {
            var values = cm.GetListWithCategory();
            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {
            ViewBag.Id = id;
            var values = cm.GetBlogById(id);
            return View(values);
        }
    }
}
