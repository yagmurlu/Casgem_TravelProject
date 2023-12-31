﻿using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class AdminMessageController : Controller
    {
        // GET: AdminMessage
        TravelContext travelContext = new TravelContext();

       
        public ActionResult Index()
        {
            var values = travelContext.FooterContacts.ToList();
            return View(values);
        }

        public ActionResult EditContact(int id)
        {
            var value = travelContext.FooterContacts.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult EditContact(FooterContact p)
        {
            var value = travelContext.FooterContacts.Find(p.FooterID);
            value.Phone = p.Phone;
            value.Mail = p.Mail;
            value.Address = p.Address;
            value.Icon = p.Icon;
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}