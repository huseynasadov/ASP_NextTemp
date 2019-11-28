using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASPFinal.Areas.Control.Filters;
using ASPFinal.DAL;
using ASPFinal.Helpers;
using ASPFinal.Models;

namespace ASPFinal.Areas.Control.Controllers
{
    [Auth]
    public class BlogsController : Controller
    {
        private JoobsyDbContext db = new JoobsyDbContext();

        // GET: Control/Blogs
        public ActionResult Index()
        {
            var blogs = db.Blogs.Include(b => b.Category);
            return View(blogs.ToList());
        }

        // GET: Control/Blogs/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.JobCategories, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "Id,Title,Slug,Content,PhotoUpload,CreatedAt,CategoryId,Status")] Blog blog)
        {
            if (blog.PhotoUpload != null)
            {
                try
                {
                    blog.Photos = FileManager.Upload(blog.PhotoUpload);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("PhotoUpload", e.Message);
                }
            }
            if (ModelState.IsValid)
            {
                blog.CreatedAt = DateTime.Now;
                db.Blogs.Add(blog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(db.JobCategories, "Id", "Name", blog.CategoryId);
            return View(blog);
        }

        // GET: Control/Blogs/Edit/5
        public ActionResult Edit(string slug)
        {
            if (slug == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blog blog = db.Blogs.FirstOrDefault(b=>b.Slug== slug);
            if (blog == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.JobCategories, "Id", "Name", blog.CategoryId);
            return View(blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "Id,Title,Slug,Content,Photos,PhotoUpload,CreatedAt,CategoryId,Status")] Blog blog)
        {
            if (blog.PhotoUpload != null)
            {
                try
                {
                    blog.Photos = FileManager.Upload(blog.PhotoUpload);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("PhotoUpload", e.Message);
                }
            }
            if (ModelState.IsValid)
            {
                blog.CreatedAt = DateTime.Now;
                db.Entry(blog).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(db.JobCategories, "Id", "Name", blog.CategoryId);
            return View(blog);
        }

        // GET: Control/Blogs/Delete/5
        public ActionResult Delete(string slug)
        {
            if (slug == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blog blog = db.Blogs.FirstOrDefault(b => b.Slug == slug);
            if (blog == null)
            {
                return HttpNotFound();
            }
            db.Blogs.Remove(blog);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
