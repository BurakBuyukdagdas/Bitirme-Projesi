using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameworl;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CV.ViewComponents.Dasboard
{
    public class Last5Certificate:ViewComponent
    {
        CertificateManager certificateManager = new CertificateManager(new EfCertificateDal());
        public IViewComponentResult Invoke()
        {
            var certificates = certificateManager.TGetList()
                .OrderByDescending(c => c.CertificateID) // Sertifikaları tarih sırasına göre sırala
                .Take(4) // Son 4 sertifikayı al
                .ToList();

            return View(certificates);
        }
    }
}
