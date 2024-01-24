using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameworl;
using Microsoft.AspNetCore.Mvc;

namespace CV.ViewComponents.About
{
    public class AboutList : ViewComponent
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal()); 

        public IViewComponentResult Invoke()
        {
            var values = aboutManager.TGetList();
            return View(values);
        }
    }
}
