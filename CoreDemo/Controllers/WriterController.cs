using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class WriterController : Controller
    {
        WriterManager wc = new WriterManager(new EfWriterRepository());

        [Authorize]
        public IActionResult Index()
        {
            var values = wc.GetAll();
            return View(values);
        }
    }
}
