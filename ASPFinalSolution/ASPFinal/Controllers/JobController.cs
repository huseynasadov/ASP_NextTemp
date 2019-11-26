using ASPFinal.DAL;
using ASPFinal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPFinal.Controllers
{
    public class JobController : BaseController
    {
        // GET: Job
        public ActionResult Index()
        {
            JobListVM model = new JobListVM {
                HeaderSetting=_db.HeaderSetting.FirstOrDefault(h=>h.Page==Models.Page.JobGrid),
                Jobs = _db.Jobs.Include("Category").OrderByDescending(j => j.CreatedAt).ToList(),
                _SidebarVM=new _SidebarVM {
                    Breadcrumb = new Breadcrumb
                    {
                        Title = "JOB LIST GRID",
                        Path = new Dictionary<string, string>()
                    },
                    JobCategories=_db.JobCategories.Where(j=>j.Status==true).ToList()
                }
            };

            model._SidebarVM.Breadcrumb.Path.Add(ViewBag.Setting.LogoName,Url.Action("index","home"));
            model._SidebarVM.Breadcrumb.Path.Add("Job",Url.Action("index","job"));
            model._SidebarVM.Breadcrumb.Path.Add( model._SidebarVM.Breadcrumb.Title,null);

            return View(model);
        }
        public ActionResult Details(string slug)
        {
            if (slug==null)
            {
                return HttpNotFound();
            }
            JobDetailVM model = new JobDetailVM {
                Breadcrumb = new Breadcrumb {
                    Title = "JOB DETAILS",
                    Path = new Dictionary<string, string> {
                        { ViewBag.Setting.LogoName, Url.Action("index", "home") },
                        { "Jobs", Url.Action("index", "job") },
                        { "JOB DETAILS", null }
                    }
                },
                Job = _db.Jobs.Include("OpeningHours").Include("Category").Include("Qualifications").Include("Responsibilities").FirstOrDefault(j => j.Slug == slug),
                HeaderSetting = _db.HeaderSetting.FirstOrDefault(h => h.Page == Models.Page.JobDetail),
            };

            if (model.Job==null)
            {
                return HttpNotFound();
            }

            return View(model);
        }
        public ActionResult Post()
        {
            Breadcrumb Breadcrumb = new Breadcrumb
            {
                Title = "Post a JOB",
                Path = new Dictionary<string, string> {
                        { ViewBag.Setting.LogoName, Url.Action("index", "home") },
                        { "Jobs", Url.Action("index", "job") },
                        { "Post a JOB", null }
                    }
            };
            return View(Breadcrumb);
        }
    }
}