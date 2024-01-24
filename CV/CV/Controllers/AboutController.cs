using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameworl;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CV.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());

        [HttpGet]
        public IActionResult Index()
        {
            var valeus = aboutManager.TGetByID(1);
            return View(valeus);

        }

        [HttpPost]
        public IActionResult Index(About about)
        {
            aboutManager.Tupdate(about);
            return RedirectToAction("Index", "Default");

        }
    }
}
