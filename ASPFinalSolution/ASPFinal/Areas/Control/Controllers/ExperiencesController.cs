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
    public class ExperiencesController : Controller
    {
        private JoobsyDbContext db = new JoobsyDbContext();

        // GET: Control/Experiences
        public ActionResult Index()
        {
            var experiences = db.Experiences.Include(e => e.Candidate).Include(e => e.Category);
            return View(experiences.ToList());
        }

        // GET: Control/Experiences/Create
        public ActionResult Create()
        {
            ViewBag.CandidateId = new SelectList(db.Candidates, "Id", "Firstname");
            ViewBag.JobCategoryId = new SelectList(db.JobCategories, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Company,JobCategoryId,BeginDate,FinalDate,Salary,Website,Address,CandidateId")] Experience experience)
        {
            if (ModelState.IsValid)
            {
                db.Experiences.Add(experience);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CandidateId = new SelectList(db.Candidates, "Id", "Firstname", experience.CandidateId);
            ViewBag.JobCategoryId = new SelectList(db.JobCategories, "Id", "Name", experience.JobCategoryId);
            return View(experience);
        }

        // GET: Control/Experiences/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Experience experience = db.Experiences.Find(id);
            if (experience == null)
            {
                return HttpNotFound();
            }
            ViewBag.CandidateId = new SelectList(db.Candidates, "Id", "Firstname", experience.CandidateId);
            ViewBag.JobCategoryId = new SelectList(db.JobCategories, "Id", "Name", experience.JobCategoryId);
            return View(experience);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Company,JobCategoryId,BeginDate,FinalDate,Salary,Website,Address,CandidateId")] Experience experience)
        {
            if (ModelState.IsValid)
            {
                db.Entry(experience).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CandidateId = new SelectList(db.Candidates, "Id", "Firstname", experience.CandidateId);
            ViewBag.JobCategoryId = new SelectList(db.JobCategories, "Id", "Name", experience.JobCategoryId);
            return View(experience);
        }

        // GET: Control/Experiences/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Experience experience = db.Experiences.Find(id);
            if (experience == null)
            {
                return HttpNotFound();
            }
            db.Experiences.Remove(experience);
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
