using Microsoft.AspNetCore.Mvc;

namespace CV.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
