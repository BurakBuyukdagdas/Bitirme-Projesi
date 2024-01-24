using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CertificateValidator:AbstractValidator<Certificate>
    {
        public CertificateValidator()
        {
            RuleFor(x => x.Title).NotEmpty().MaximumLength(120).WithMessage("Lütfen Başlık Ekleyiniz.");
            RuleFor(x => x.Description).MaximumLength(230).NotEmpty().WithMessage("Lütfen Açıklama Ekleyiniz.");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen Görsel Ekleyiniz.");
            RuleFor(x => x.Paltform).NotEmpty().WithMessage("Lütfen Platform Görseli Ekleyiniz.");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Lütfen Tamamlama Aşaması Ekleyiniz.");
            RuleFor(x => x.Status).NotEmpty().WithMessage("Lütfen Durum Ekleyiniz.");
        }
    }
}

//Yukarıda ki alan şartları göstermektedir. FluentValidation.Core kütüphanesi eklenmelidir. 
//NotEmpty : Boş Geçilemez
//MaximumLength : Karakter Sayısı
//WithMessage : Mesaj

