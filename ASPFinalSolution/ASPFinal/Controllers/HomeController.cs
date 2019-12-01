using ASPFinal.DAL;
using ASPFinal.Filter;
using ASPFinal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPFinal.Controllers
{
    [AuthFilter]
    public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Index(int? page)
        {
            int count = page ?? 1;

            HomeVM model = new HomeVM {
                Setting = ViewBag.Setting,
                HeaderSetting = _db.HeaderSetting.FirstOrDefault(h => h.Page == Models.Page.Home),
                Jobs = _db.Jobs.Include("Category").OrderByDescending(j => j.CreatedAt).Skip((count-1)*4).Take(4).ToList(),
                AllJobs=_db.Jobs.Include("Category").ToList(),
                HowItWorks = _db.HowItWorks.Where(e => e.Status == true).OrderBy(h => h.OrderBy).ToList(),
                Employers=_db.Employers.Include("CompanyPhotos").Where(e=>e.Status==true).OrderBy(e=>e.CreatedAt).ToList(),
                BlogCounts=_db.Blogs.ToList().Count(),
                Partners=_db.Partners.Where(e => e.Status == true).OrderBy(p=>p.OrderBy).ToList(),
                Candidates=_db.Candidates.Where(e => e.Status == true).ToList(),
                Pagination=new PaginationVM {
                    Page= PagePag.Home,
                    CurrentPage=count
                }
            };
            int pageCount = _db.Jobs.Count() / 4;
            if (_db.Jobs.Count() % 4 != 0)
            {
                pageCount++;
            }
            model.Pagination.PageCount = pageCount;
            return View(model);
        }
    }
}