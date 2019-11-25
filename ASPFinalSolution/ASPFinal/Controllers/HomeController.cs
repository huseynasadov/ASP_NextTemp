using ASPFinal.DAL;
using ASPFinal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPFinal.Controllers
{
    public class HomeController : Controller
    {
        private readonly JoobsyDbContext _db;
        public HomeController()
        {
            _db = new JoobsyDbContext();
        }
        // GET: Home
        public ActionResult Index()
        {
            HomeVM model = new HomeVM {
                Setting = _db.Settings.FirstOrDefault(),
                HeaderSetting = _db.HeaderSetting.FirstOrDefault(h => h.Page == Models.Page.Home),
                Jobs = _db.Jobs.Include("Category").OrderByDescending(j => j.CreatedAt).ToList(),
                HowItWorks = _db.HowItWorks.Where(e => e.Status == true).OrderBy(h => h.OrderBy).ToList(),
                Employers=_db.Employers.Include("CompanyPhotos").Where(e=>e.Status==true).OrderBy(e=>e.CreatedAt).ToList(),
                BlogCounts=_db.Blogs.ToList().Count(),
                Partners=_db.Partners.Where(e => e.Status == true).OrderBy(p=>p.OrderBy).ToList(),
                Candidates=_db.Candidates.Where(e => e.Status == true).ToList()
            };
            return View(model);
        }
    }
}