using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFrameworl;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CV.Controllers
{
    public class ProjectController : Controller
    {
        ProjecktManager projecktManager = new ProjecktManager(new EfProjectDal());
        public IActionResult Index()
        {
            var values = projecktManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProject()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProject(Project project)
        {
            projecktManager.TAdd(project);
            return RedirectToAction("Index");
            //Alt Kısım Kısıtlamaların yapıldığı alan (Solition explorer ValidationRules Alında Bulunuyor.
            //ProjectValidator dan geliyor. FluentValidation Kütüphanesi ile yüklendi.)
            ProjectValidator validations = new ProjectValidator();
            ValidationResult results = validations.Validate(project);
            if (results.IsValid) //Eğer işlem yapılırsa kaydet ve anasayfaya dön
            {
                projecktManager.TAdd(project);
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
        public IActionResult DeleteProject(int id)
        {
            var values = projecktManager.TGetByID(id);
            projecktManager.TDelete(values);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult EditProject(int id)
        {
            var values = projecktManager.TGetByID(id);
            return View(values);
        }



        [HttpPost]
        public IActionResult EditProject(Project project)
        {
            ProjectValidator validations = new ProjectValidator();
            ValidationResult results = validations.Validate(project);
            if (results.IsValid)
            {
                projecktManager.Tupdate(project);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }

    }
}
