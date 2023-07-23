using Casgem_CodeFirstProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialSection()
        {
            return PartialView();
        }
        public PartialViewResult PartialSection1()
        {
            return PartialView();
        }
        public PartialViewResult PartialSection2()
        {
            return PartialView();
        }
        public PartialViewResult PartialSection3()
        {
            return PartialView();
        }
    }
}