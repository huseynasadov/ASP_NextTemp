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
using ASPFinal.Models;

namespace ASPFinal.Areas.Control.Controllers
{
    [Auth]
    public class JobsController : Controller
    {
        private JoobsyDbContext db = new JoobsyDbContext();

        // GET: Control/Jobs
        public ActionResult Index()
        {
            var jobs = db.Jobs.Include(j => j.Category);
            return View(jobs.ToList());
        }


        // GET: Control/Jobs/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.JobCategories, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "Id,CompanyName,Title,Slug,CategoryId,JobEduLevellId,JobExpYear,JobType,Gender,Shift,Address,MinSalary,MaxSalary,WebSite,Email,Phone,Desc,Photo,CreatedAt,Hours,Status")] Job job)
        {
            if (ModelState.IsValid)
            {
                db.Jobs.Add(job);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(db.JobCategories, "Id", "Name", job.CategoryId);
            return View(job);
        }

        // GET: Control/Jobs/Edit/5
        public ActionResult Edit(string slug)
        {
            if (slug == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job job = db.Jobs.FirstOrDefault(j=>j.Slug== slug);
            if (job == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.JobCategories, "Id", "Name", job.CategoryId);
            return View(job);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "Id,CompanyName,Title,Slug,CategoryId,JobEduLevellId,JobExpYear,JobType,Gender,Shift,Address,MinSalary,MaxSalary,WebSite,Email,Phone,Desc,Photo,CreatedAt,Hours,Status")] Job job)
        {
            if (ModelState.IsValid)
            {
                db.Entry(job).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(db.JobCategories, "Id", "Name", job.CategoryId);
            return View(job);
        }

       
        // Get: Control/Jobs/Delete/5
        public ActionResult Delete(string slug)
        {
            if (slug == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job job = db.Jobs.FirstOrDefault(j => j.Slug == slug);
            if (job == null)
            {
                return HttpNotFound();
            }
            db.Jobs.Remove(job);
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
