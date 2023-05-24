using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.FluentValidation;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {

        WriterManager wm = new WriterManager(new EfWriterRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
		public IActionResult Index(Writer writer)
		{
            WriterValidator validator = new WriterValidator();
            ValidationResult validationResult= validator.Validate(writer);
            if (validationResult.IsValid)
            {
            writer.WriterStatus = true;
            writer.WriterAbout = "Deneme hakkında";
            wm.WriterAdd(writer);
			return RedirectToAction("Index","Blog");
            }

            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
		}
	}
}
