using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            var values = travelContext.Sliders.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult EditHomeSlider(int id)
        {
            var value = travelContext.Sliders.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult EditHomeSlider(Slider slider)
        {
            var value = travelContext.Sliders.Find(slider.SliderId);
            value.SliderTitle = slider.SliderTitle;
            value.SliderTitle2 = slider.SliderTitle2;
            value.SliderDescription = slider.SliderDescription;

            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}