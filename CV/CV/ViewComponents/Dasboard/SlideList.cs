using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameworl;
using Microsoft.AspNetCore.Mvc;

namespace CV.ViewComponents.Dasboard
{
    public class SlideList : ViewComponent
    {
        ProjecktManager projecktManager = new ProjecktManager(new EfProjectDal());

        public IViewComponentResult Invoke()
        {
            var values = projecktManager.TGetList();
            return View(values);
        }
    }
}
