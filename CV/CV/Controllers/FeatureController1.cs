using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFrameworl;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV.Controllers
{
    public class FeatureController1 : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());

        [HttpGet]
        public IActionResult Index()
        {
            var valeus = featureManager.TGetByID(1);
            return View(valeus);

        }

        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            featureManager.Tupdate(feature);
            return RedirectToAction("Index", "FeatureController1");

        }
    }
}
