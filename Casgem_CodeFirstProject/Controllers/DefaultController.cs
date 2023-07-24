using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        TravelContext travelContext=new TravelContext();
        public ActionResult Index()
        {
            return View();
        }
       
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialBooking()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialSliderScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialSlider()
        {
            var values = travelContext.Sliders.ToList();
            return PartialView(values);
        }
       
        public PartialViewResult PartialFeature()
        {
            return PartialView();
        }
        public PartialViewResult PartialDestination()
        {
            var values = travelContext.Destinations.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAbout()
        {
            return PartialView();
        }
        public PartialViewResult PartialBookingCover()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

        public PartialViewResult PartialMainScript()
        {
            return PartialView();
        }

    }
}