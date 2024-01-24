using Microsoft.AspNetCore.Mvc;

namespace CV.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
