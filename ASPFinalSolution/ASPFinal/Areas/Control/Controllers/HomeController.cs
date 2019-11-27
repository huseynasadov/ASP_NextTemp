﻿using ASPFinal.Areas.Control.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPFinal.Areas.Control.Controllers
{
    [Auth]
    public class HomeController : Controller
    {
        // GET: Control/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}