using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ProjectValidator:AbstractValidator<Project>
    {
        public ProjectValidator()
        {
            RuleFor(x=>x.Title).NotEmpty().MaximumLength(20).WithMessage("Proje Adı Boş Geçilemez");
            RuleFor(x=>x.Description).NotEmpty().MaximumLength(30).WithMessage("Proje Açıklaması Boş Geçilemez");
            RuleFor(x=>x.Image).NotEmpty().WithMessage("Proje Görseli Boş Geçilemez");
        }
    }
}
