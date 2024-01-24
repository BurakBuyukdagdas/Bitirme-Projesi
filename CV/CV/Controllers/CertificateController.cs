using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFrameworl;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CV.Controllers
{
    public class CertificateController : Controller
    {
        CertificateManager certificateManager = new CertificateManager(new EfCertificateDal());

        public IActionResult Index()
        {
            var values = certificateManager.TGetList();
            return View(values);
        }


        [HttpGet]
        public IActionResult AddCertificate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCertificate(Certificate certificate)
        {
            //Alt Kısım Kısıtlamaların yapıldığı alan (Solition explorer ValidationRules Alında Bulunuyor.
            //CertificateValidator dan geliyor. FluentValidation Kütüphanesi ile yüklendi.)
            CertificateValidator validations = new CertificateValidator();
            ValidationResult results=validations.Validate(certificate);
            if (results.IsValid) //Eğer işlem yapılırsa kaydet ve anasayfaya dön
            {
                certificateManager.TAdd(certificate);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors) //Kaydetme başarısızsa hata mesajanı yaz.
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeleteCertificate(int id)
        {
            var values = certificateManager.TGetByID(id);
            certificateManager.TDelete(values);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult EditCertificate(int id)
        {
            var values = certificateManager.TGetByID(id);
            return View(values);
        }



        [HttpPost]
        public IActionResult EditCertificate(Certificate certificate)
        {
            CertificateValidator validations = new CertificateValidator();
            ValidationResult results = validations.Validate(certificate);
            if (results.IsValid)
            {
                certificateManager.Tupdate(certificate);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
            
        }






    }
}
