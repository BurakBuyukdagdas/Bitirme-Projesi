using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameworl;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CV.ViewComponents.Dasboard
{
    public class Last5Projects:ViewComponent
    {
        ProjecktManager projecktManager = new ProjecktManager(new EfProjectDal());
        public IViewComponentResult Invoke()
        {
            var project = projecktManager.TGetList()
               .OrderByDescending(c => c.ProjectID) // Sertifikaları tarih sırasına göre sırala
               .Take(4) // Son 4 sertifikayı al
               .ToList();

            return View(project);
        }
    }
}
