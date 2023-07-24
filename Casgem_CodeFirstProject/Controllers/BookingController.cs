using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking
        TravelContext travelContext = new TravelContext();
      

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Booking booking)
        {
            travelContext.Bookings.Add(booking);
            booking.BookingDate = DateTime.Parse(DateTime.Now.ToString("dd-MM-yyyy"));
            travelContext.SaveChanges();
            return RedirectToAction("Index", "Default");
        }
        public ActionResult GetBooking()
        {
            return View();
        }
        [HttpGet]
        public ActionResult EditBooking(int id)
        {
            var value = travelContext.Bookings.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult EditBooking(Booking booking)
        {
            var value = travelContext.Bookings.Find(booking.BookingID);
            value.CustomerName = booking.CustomerName;
            value.Destination = booking.Destination;
            value.Duration = booking.Duration;
            value.Mail = booking.Mail;
            value.BookingDate = booking.BookingDate;

            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}