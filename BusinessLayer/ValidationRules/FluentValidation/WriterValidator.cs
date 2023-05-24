using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
	public class WriterValidator : AbstractValidator<Writer>
	{

		public WriterValidator()
		{
			RuleFor(w => w.WriterName).NotEmpty().WithMessage("Yazar İsmi Boş Bırakılamaz");
			RuleFor(w=>w.WriterMail).NotEmpty().WithMessage("Yazar Maili Boş Bırakılamaz");
			RuleFor(w => w.WriterPassword).NotEmpty().WithMessage("Yazar parolası boş geçilemez");
			RuleFor(w => w.WriterPassword).Matches(@"[A-Z]+").WithMessage("Parolada minimum bir büyük harf bulunmalıdır")
				.Matches(@"[a-z]+").WithMessage("Parolada minimum bir küçük harf bulunmalıdır")
				.Matches(@"[0-9]+").WithMessage("Parolada en az bir rakam bulunmalıdır");
		}

	}
}
