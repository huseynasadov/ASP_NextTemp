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
    public class BlogController : BaseController
    {
        // GET: Blog
        public ActionResult Index(int? page)
        {
            int count = page ?? 1;
            DateTime archDate = DateTime.Now.AddMonths(-1);
            BlogListVM model = new BlogListVM
            {
                HeaderSetting = _db.HeaderSetting.FirstOrDefault(h => h.Page == Models.Page.BlogList),
                Blogs = _db.Blogs.Include("BlogReview").Where(c=>c.Status==true).OrderByDescending(b=>b.CreatedAt).Skip((count - 1) * 4).Take(4).ToList(),
                _SidebarVM = new _SidebarVM
                {
                    JobCategories = _db.JobCategories.ToList(),
                    Breadcrumb = new Breadcrumb
                    {
                        Title = "Blog List",
                        Path = new Dictionary<string, string> {
                            {ViewBag.Setting.LogoName,Url.Action("index","home")},
                            {"Blog",Url.Action("index","Blog")},
                            { "Blog List",null}
                        }
                    },
                    ArchiveBlogs=_db.Blogs.Where(b=>b.CreatedAt< archDate).OrderByDescending(b=>b.CreatedAt).ToList()
                },
                Pagination = new PaginationVM
                {
                    Page = PagePag.Blog,
                    CurrentPage = count
                }
            };
            int pageCount = _db.Blogs.Count() / 4;
            if (_db.Blogs.Count() % 4 != 0)
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
            DateTime archDate = DateTime.Now.AddMonths(-1);
            BlogDetailVM model = new BlogDetailVM
            {

                Blog = _db.Blogs.Include("BlogReview.Candidate").Include("Category").Where(j => j.Status == true).FirstOrDefault(j => j.Slug == slug),
                HeaderSetting = _db.HeaderSetting.FirstOrDefault(h => h.Page == Models.Page.BlogDetail),
                _Sidebar = new _SidebarVM
                {
                    Breadcrumb = new Breadcrumb
                    {
                        Title = "Blog Detail",
                        Path = new Dictionary<string, string> {
                            {ViewBag.Setting.LogoName,Url.Action("index","home")},
                            {"Blog",Url.Action("index","Blog")},
                            { "Blog Detail",null}
                        }
                    },
                    JobCategories = _db.JobCategories.Where(j => j.Status == true).ToList(),
                    ArchiveBlogs = _db.Blogs.Where(b => b.CreatedAt < archDate).OrderByDescending(b => b.CreatedAt).ToList()
                }
                
            };

            if (model.Blog == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }
    }
}