using ASPFinal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPFinal.Controllers
{
    public class CandidateController : BaseController
    {
        // GET: Candidates
        public ActionResult Index()
        {
            CandidateListVM model = new CandidateListVM {
                HeaderSetting=_db.HeaderSetting.FirstOrDefault(h=>h.Page==Models.Page.CandidateList),
                Candidates=_db.Candidates.Include("Skils").Where(c=>c.Status==true).ToList(),
                _SidebarVM = new _SidebarVM {
                    JobCategories=_db.JobCategories.ToList(),
                    Professions=_db.Candidates.Select(c=>c.Profession).ToList(),
                    Skills=_db.Skills.ToList(),
                    Breadcrumb=new Breadcrumb {
                        Title="Candidates Listing",
                        Path=new Dictionary<string, string> {
                            {ViewBag.Setting.LogoName,Url.Action("index","home")},
                            {"Candidates",Url.Action("index","candidate")},
                            { "Candidates Listing",null}
                        }
                    }
                }
            };
            return View(model);
        }
        public ActionResult Details(string slug)
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}