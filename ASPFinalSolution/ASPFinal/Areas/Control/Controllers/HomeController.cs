using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPFinal.Areas.Control.Controllers
{
    public class HomeController : Controller
    {
        // GET: Control/Home
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}