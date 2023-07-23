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
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialSection()
        {
            return PartialView();
        }
        public PartialViewResult PartialTypesOfTravel()
        {
            return PartialView();
        }
        public PartialViewResult PartialTravelRegions()
        {
            return PartialView();
        }
    }
}