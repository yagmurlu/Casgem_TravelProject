using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class ExploreController : Controller
    {
        // GET: Explore
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            return View();
        }
      
        public ActionResult GetImage()
        {
            var values = travelContext.Galeries.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult EditImage(int id)
        {
            var value = travelContext.Galeries.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult EditImage(Galery galery)
        {
            var value = travelContext.Galeries.Find(galery.GaleryId);
            value.Title = galery.Title;
            value.Description = galery.Description;
            value.ImageUrl = galery.ImageUrl;

            travelContext.SaveChanges();
            return RedirectToAction("GetImage");
        }
        [HttpGet]
        public ActionResult AddImage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddImage(Galery galery)
        {
            travelContext.Galeries.Add(galery);
            travelContext.SaveChanges();
            return RedirectToAction("GetImage");
        }
        public ActionResult DeleteImage(int id)
        {
            var value = travelContext.Galeries.Find(id);
            travelContext.Galeries.Remove(value);
            travelContext.SaveChanges();
            return RedirectToAction("GetImage");
        }

        public PartialViewResult PartialService()
        {
            var values = travelContext.Services.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialImage()
        {
            var values = travelContext.Galeries.ToList();
            return PartialView(values);
        }
    }
}