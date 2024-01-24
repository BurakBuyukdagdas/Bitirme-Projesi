using Microsoft.AspNetCore.Mvc;

namespace CV.Controllers
{
    public class DasboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
