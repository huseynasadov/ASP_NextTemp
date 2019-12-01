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
    public class PageController : BaseController 
    {
        // GET: Page
        public ActionResult About()
        {
            AboutVM model = new AboutVM {
                breadcrumb = new Breadcrumb
                {
                    Title = "About Us",
                    Path = new Dictionary<string, string> {
                            {ViewBag.Setting.LogoName,Url.Action("index","home")},
                            {"Page",Url.Action("About","Page")},
                            { "About Us",null}
                        }
                },
                HeaderSetting = _db.HeaderSetting.FirstOrDefault(h => h.Page == Models.Page.AboutUs),
                Jobs = _db.Jobs.Include("Category").OrderByDescending(j => j.CreatedAt).ToList(),
                Abouts=_db.AboutUs.Where(a=>a.Status==true).Take(3).ToList(),
                Partners=_db.Partners.Where(p=>p.Status==true).ToList(),
                Employer=_db.Employers.Include("CompanyPhotos").Where(e=>e.Status==true).OrderByDescending(o=>o.CreatedAt).FirstOrDefault()
            };
            return View(model);
        }

        public ActionResult Service()
        {
            ServiceVM model = new ServiceVM
            {
                HeaderSetting = _db.HeaderSetting.FirstOrDefault(h => h.Page == Models.Page.Service),
                breadcrumb = new Breadcrumb
                {
                    Title = "Services",
                    Path = new Dictionary<string, string> {
                            {ViewBag.Setting.LogoName,Url.Action("index","home")},
                            {"Page",Url.Action("About","Page")},
                            { "Services",null}
                        }
                },
                Services=_db.Services.Where(s=>s.Status==true).ToList(),
                Employer = _db.Employers.Include("CompanyPhotos").Where(e => e.Status == true).OrderBy(o => o.CreatedAt).FirstOrDefault()
            };
            return View(model);
        }
        public ActionResult Team()
        {
            TeamVM model = new TeamVM {
                HeaderSetting = _db.HeaderSetting.FirstOrDefault(h => h.Page == Models.Page.Team),
                breadcrumb = new Breadcrumb
                {
                    Title = "Awesome Team",
                    Path = new Dictionary<string, string> {
                            {ViewBag.Setting.LogoName,Url.Action("index","home")},
                            {"Page",Url.Action("About","Page")},
                            { "Team",null}
                        }
                },
                Teams=_db.Teams.Include("Category").Include("TeamSocials").Where(t=>t.Status==true).OrderBy(o=>o.OrderBy).ToList()
            };
            return View(model);
        }
        public ActionResult Faq()
        {
            FaqVM model = new FaqVM {
                HeaderSetting = _db.HeaderSetting.FirstOrDefault(h => h.Page == Models.Page.Faq),
                breadcrumb = new Breadcrumb
                {
                    Title = "FAQ",
                    Path = new Dictionary<string, string> {
                            {ViewBag.Setting.LogoName,Url.Action("index","home")},
                            {"Page",Url.Action("About","Page")},
                            { "FAQ",null}
                        }
                },
                Faqs=_db.Faqs.Where(f=>f.Status==true).OrderBy(o=>o.OrderBy).ToList()
            };
            return View(model);
        }
        public ActionResult Pricing()
        {
            PricingVM model = new PricingVM {
                HeaderSetting = _db.HeaderSetting.FirstOrDefault(h => h.Page == Models.Page.Pricing),
                breadcrumb = new Breadcrumb
                {
                    Title = "Pricing Plan",
                    Path = new Dictionary<string, string> {
                            {ViewBag.Setting.LogoName,Url.Action("index","home")},
                            {"Page",Url.Action("About","Page")},
                            { "Pricing Plan",null}
                        }
                },
                Pricing = _db.Pricings.Where(f => f.Status == true).OrderBy(o => o.OrderBy).ToList()
            };
            return View(model);
        }
    }
}