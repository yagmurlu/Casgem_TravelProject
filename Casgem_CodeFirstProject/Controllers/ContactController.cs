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
        public ActionResult Index()
        {
            return View();
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