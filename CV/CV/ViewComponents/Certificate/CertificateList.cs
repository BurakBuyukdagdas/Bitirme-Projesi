using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameworl;
using Microsoft.AspNetCore.Mvc;

namespace CV.ViewComponents.Certificate
{
    public class CertificateList : ViewComponent
    {
        CertificateManager certificateManager = new CertificateManager(new EfCertificateDal());
        public IViewComponentResult Invoke()
        {
            var values = certificateManager.TGetList();
            return View(values);
        }
    }
}
