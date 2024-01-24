using Microsoft.AspNetCore.Mvc;

namespace CV.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult PartialSideBar()  //Sol menünün olduğu bölüm
        {
            return PartialView();
        }




        public PartialViewResult PartialFooter()  //Footer bölümü
        {
            return PartialView();
        }



        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }



        public PartialViewResult PartialScript()
        {
            return PartialView();
        }

        public PartialViewResult NavigationPartial()
        {
            return PartialView();
        }
        public PartialViewResult NewSidebar()
        {
            return PartialView();
        }
    }
}
