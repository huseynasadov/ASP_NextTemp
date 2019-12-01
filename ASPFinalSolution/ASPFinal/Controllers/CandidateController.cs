using ASPFinal.Filter;
using ASPFinal.Models;
using ASPFinal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPFinal.Controllers
{
    [AuthFilter]
    public class CandidateController : BaseController
    {
        // GET: Candidates
        public ActionResult Index(int? page)
        {
            int count = page ?? 1;
            CandidateListVM model = new CandidateListVM {
                HeaderSetting=_db.HeaderSetting.FirstOrDefault(h=>h.Page==Models.Page.CandidateList),
                Candidates=_db.Candidates.Include("Skils").Where(c=>c.Status==true).OrderByDescending(a=>a.BirthDate).Skip((count - 1) * 4).Take(4).ToList(),
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
                },
                Pagination = new PaginationVM
                {
                    Page = PagePag.Candidate,
                    CurrentPage = count
                }
            };
            int pageCount = _db.Candidates.Count() / 4;
            if (_db.Candidates.Count() % 4 != 0)
            {
                pageCount++;
            }
            model.Pagination.PageCount = pageCount;
            return View(model);
        }
        public ActionResult Details(string slug)
        {
            if (slug == null)
            {
                return HttpNotFound();
            }
            CandidateDetailVM model = new CandidateDetailVM
            {
                Candidate = _db.Candidates.Include("CandidateSocials.SocialLink").Include("Educations").Include("Experiences.Category").Include("Skils").Where(c=>c.Status==true).FirstOrDefault(j => j.Slug == slug),
                HeaderSetting = _db.HeaderSetting.FirstOrDefault(h => h.Page == Models.Page.CandidateDetail),
            };

            if (model.Candidate == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

       
        public ActionResult Create()
        {
            CandidateListVM model = new CandidateListVM
            {
                HeaderSetting = _db.HeaderSetting.FirstOrDefault(h => h.Page == Models.Page.CandidateResume),
                _SidebarVM = new _SidebarVM
                {
                    Breadcrumb = new Breadcrumb
                    {
                        Title = "Candidate Resume",
                        Path = new Dictionary<string, string> {
                            {ViewBag.Setting.LogoName,Url.Action("index","home")},
                            {"Candidates",Url.Action("index","candidate")},
                            { "Candidate Resume",null}
                        }
                    }
                }
            };

            return View(model);
        }
    }
}