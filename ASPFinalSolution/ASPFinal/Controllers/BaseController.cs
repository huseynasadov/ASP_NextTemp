using ASPFinal.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPFinal.Controllers
{
    public class BaseController : Controller
    {
        public  JoobsyDbContext _db;
        public BaseController()
        {
            _db = new JoobsyDbContext();
            ViewBag.Setting = _db.Settings.Include("SettingSocials.SocialLink").FirstOrDefault();
        }
    }
}