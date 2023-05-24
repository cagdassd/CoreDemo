using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class NewsLetterController : Controller
	{

		NewsletterManager nm = new NewsletterManager(new EfNewsletterRepository());

		[HttpGet]
		public PartialViewResult SubscribeMail()
		{
			return PartialView();
		}
		[HttpPost]
		public PartialViewResult SubscribeMail(NewsLetter nl)
		{
			nl.MailStatus = true;
			nm.NewsletterAdd(nl);
			Response.Redirect("/Blog/Index/");
			return PartialView();
		}
	}
}
