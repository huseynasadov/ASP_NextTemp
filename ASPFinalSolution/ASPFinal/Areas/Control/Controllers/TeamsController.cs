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
    public class TeamsController : Controller
    {
        private JoobsyDbContext db = new JoobsyDbContext();

        // GET: Control/Teams
        public ActionResult Index()
        {
            var teams = db.Teams.Include(t => t.Category);
            return View(teams.ToList());
        }


        // GET: Control/Teams/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.JobCategories, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Firstname,Lastname,Slug,Photo,PhotoUpload,CategoryId,ShortInfo,OrderBy,Status")] Team team)
        {
            if (team.PhotoUpload != null)
            {
                try
                {
                    team.Photo = FileManager.Upload(team.PhotoUpload);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("PhotoUpload", e.Message);
                }
            }
            if (ModelState.IsValid)
            {
                team.Slug = team.Firstname.ToLower() + "-" + team.Lastname.ToLower(); 
                db.Teams.Add(team);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(db.JobCategories, "Id", "Name", team.CategoryId);
            return View(team);
        }

        // GET: Control/Teams/Edit/5
        public ActionResult Edit(string slug)
        {
            if (slug == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Team team = db.Teams.FirstOrDefault(m=>m.Slug== slug);
            if (team == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.JobCategories, "Id", "Name", team.CategoryId);
            return View(team);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Firstname,Lastname,Slug,Photo,PhotoUpload,CategoryId,ShortInfo,OrderBy,Status")] Team team)
        {
            if (team.PhotoUpload != null)
            {
                try
                {
                    team.Photo = FileManager.Upload(team.PhotoUpload);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("PhotoUpload", e.Message);
                }
            }
            if (ModelState.IsValid)
            {
                team.Slug = team.Firstname.ToLower() + "-" + team.Lastname.ToLower();
                db.Entry(team).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(db.JobCategories, "Id", "Name", team.CategoryId);
            return View(team);
        }

        // GET: Control/Teams/Delete/5
        public ActionResult Delete(string slug)
        {
            if (slug == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Team team = db.Teams.FirstOrDefault(m => m.Slug == slug);
            if (team == null)
            {
                return HttpNotFound();
            }
            db.Teams.Remove(team);
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
