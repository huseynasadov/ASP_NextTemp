using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPFinal.Controllers
{
    public class PageController : Controller
    {
        // GET: Page
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Service()
        {
            return View();
        }
        public ActionResult Team()
        {
            return View();
        }
        public ActionResult Faq()
        {
            return View();
        }
        public ActionResult Pricing()
        {
            return View();
        }
    }
}