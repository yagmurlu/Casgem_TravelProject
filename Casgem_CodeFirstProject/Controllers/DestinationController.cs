using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class DestinationController : Controller
    {
        // GET: Destination
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            var values = travelContext.Destinations.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddDestination()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddDestination(Destination destination)
        {
            travelContext.Destinations.Add(destination);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditDestination(int id)
        {
            var value = travelContext.Destinations.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult EditDestination(Destination destination)
        {
            var value = travelContext.Destinations.Find(destination.DestinationID);
            value.DestinationName = destination.DestinationName;
            value.DayNight = destination.DayNight;
            value.Capacity = destination.Capacity;
            value.Description = destination.Description;
            value.Price = destination.Price;
            value.ImageURL = destination.ImageURL;
            value.Status = destination.Status;

            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}