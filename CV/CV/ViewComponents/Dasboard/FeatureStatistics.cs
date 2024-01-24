using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;

namespace CV.ViewComponents.Dasboard
{
    public class FeatureStatistics : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Projects.Count();
            ViewBag.v2 = c.Certificates.Count();
            // Yazılım ile tanışma yılı ve gün sayısını hesapla
            DateTime tanismaYili = new DateTime(2022, 9, 12); // Tanışma yılını ayarlayın
            DateTime simdikiTarih = DateTime.Now;
            int gecenYil = simdikiTarih.Year - tanismaYili.Year;
            int gecenGun = (int)(simdikiTarih - tanismaYili).TotalDays;

            ViewBag.tanismaYili = gecenYil;
            ViewBag.gunSayisi = gecenGun;
            return View();
        }

    }
}
