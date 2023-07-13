using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    [Authorize]
    public class AdminGuideController : Controller
    {
        // GET: AdminGuide
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            var values= travelContext.Guides.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddGuide()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddGuide(Guide guide)
        {
            travelContext.Guides.Add(guide);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteGuide(int id)
        {
            var value = travelContext.Guides.Find(id);
            travelContext.Guides.Remove(value);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditGuide(int id)
        {
            var value = travelContext.Guides.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult EditGuide(Guide guide)
        {
            var value = travelContext.Guides.Find(guide.GuideId);
            value.GuideName = guide.GuideName;
            value.GuideTitle= guide.GuideTitle;
            value.GuideImageURL = guide.GuideImageURL;
            
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}