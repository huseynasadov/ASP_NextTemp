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
    public class EmployerController : BaseController
    {
        // GET: Employer
        public ActionResult Index(int? page)
        {

            int count = page ?? 1;
            EmployerListVM model = new EmployerListVM
            {
                HeaderSetting = _db.HeaderSetting.FirstOrDefault(h => h.Page == Models.Page.EmployerList),
                Employers = _db.Employers.Include("EmployerCategory.Category").OrderByDescending(j => j.CreatedAt).Skip((count - 1) * 6).Take(6).ToList(),
                _SidebarVM = new _SidebarVM
                {
                    Breadcrumb = new Breadcrumb
                    {
                        Title = "Employer List",
                        Path = new Dictionary<string, string>()
                    },
                    JobCategories = _db.JobCategories.Where(j => j.Status == true).ToList()
                },Pagination = new PaginationVM {
                    Page = PagePag.Blog,
                    CurrentPage = count
                }
            };
            int pageCount = _db.Employers.Count() / 6;
            if (_db.Employers.Count() % 6 != 0)
            {
                pageCount++;
            }
            model.Pagination.PageCount = pageCount;
            model._SidebarVM.Breadcrumb.Path.Add(ViewBag.Setting.LogoName, Url.Action("index", "home"));
            model._SidebarVM.Breadcrumb.Path.Add("Employer", Url.Action("index", "employer"));
            model._SidebarVM.Breadcrumb.Path.Add(model._SidebarVM.Breadcrumb.Title, null);
            return View(model);
        }
        public ActionResult Details(string slug)
        {
            if (slug == null)
            {
                return HttpNotFound();
            }
            EmployerDetailVM model = new EmployerDetailVM
            {
                Breadcrumb = new Breadcrumb
                {
                    Title = "Employer Detail",
                    Path = new Dictionary<string, string> {
                        { ViewBag.Setting.LogoName, Url.Action("index", "home") },
                        { "Employer", Url.Action("index", "Employer") },
                        { "Employer DETAILS", null }
                    }
                },
                Employer = _db.Employers.Include("EmployerCategory.Category").Include("EmployerReviews.Candidate").FirstOrDefault(j => j.Slug == slug),
                HeaderSetting = _db.HeaderSetting.FirstOrDefault(h => h.Page == Models.Page.EmlpoyerDetail),
            };

            if (model.Employer == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }
    }
}