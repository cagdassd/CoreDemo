using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class NewsletterManager : INewsletterService
	{
		INewsletterDal _newsletterDal;

		public NewsletterManager(INewsletterDal NewsletterDal)
		{
			_newsletterDal= NewsletterDal;
		}


		public void NewsletterAdd(NewsLetter newsletter)
		{
			_newsletterDal.Insert(newsletter);
		}
	}
}
