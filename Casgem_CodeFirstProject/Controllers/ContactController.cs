using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        TravelContext travelContext = new TravelContext();
        [HttpGet]
        public ActionResult Index()
        {       
            return View();
        }
        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            travelContext.Contacts.Add(contact);
            contact.MessageDate = DateTime.Parse(DateTime.Now.ToString("dd-MM-yyyy"));
            travelContext.SaveChanges();
            return RedirectToAction("Index", "Default");
        }
        public ActionResult GetContact()
        {
            var values = travelContext.Contacts.ToList();
            return View(values);
        }
        public ActionResult DeleteContact(int id)
        {
            var value = travelContext.Contacts.Find(id);
            travelContext.Contacts.Remove(value);
            travelContext.SaveChanges();
            return RedirectToAction("GetContact");
        }

        public PartialViewResult PartialSection()
        {
            return PartialView();
        }
        public PartialViewResult PartialQuickContact()
        {
            return PartialView();
        }
        public PartialViewResult PartialSendMessage()
        {
            return PartialView();
        }
    }
}