using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class AdminFeatureController : Controller
    {
        // GET: AdminFeature
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            var values = travelContext.Places.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult UpdateAdminFeature(int id)
        {
            var value = travelContext.Places.Find(id);

            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateAdminFeature(Place p)
        {
            var value = travelContext.Places.Find(p.PlaceId);
            value.Title = p.Title;
            value.Description = p.Description;
            value.ImageUrl = p.ImageUrl;
            travelContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}