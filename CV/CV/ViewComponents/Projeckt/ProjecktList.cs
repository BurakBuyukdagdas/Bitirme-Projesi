using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameworl;
using Microsoft.AspNetCore.Mvc;

namespace CV.ViewComponents.Projeckt
{
    public class ProjecktList : ViewComponent
    {
        ProjecktManager projectManager = new ProjecktManager(new EfProjectDal());

        public IViewComponentResult Invoke()
        {
            var values = projectManager.TGetList();
            return View(values);
        }
    }
}
