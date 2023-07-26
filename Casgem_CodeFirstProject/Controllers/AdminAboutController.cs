﻿using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class AdminAboutController : Controller
    {
        // GET: AdminAbout
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            var values = travelContext.Abouts.ToList();

            return View(values);
        }

        [HttpGet]
        public ActionResult AdminAboutUpdate(int id)
        {
            var values = travelContext.Abouts.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult AdminAboutUpdate(About p)
        {
            var values = travelContext.Abouts.Find(p.AboutId);
            values.Title = p.Title;
            values.Description = p.Description;
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}