using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class WriterController : Controller
    {
        WriterManager wc = new WriterManager(new EfWriterRepository());
        public IActionResult Index()
        {
            var values = wc.GetAll();
            return View(values);
        }
    }
}
