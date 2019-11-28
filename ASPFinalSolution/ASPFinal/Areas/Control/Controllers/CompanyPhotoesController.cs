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
    public class CompanyPhotoesController : Controller
    {
        private JoobsyDbContext db = new JoobsyDbContext();

        // GET: Control/CompanyPhotoes
        public ActionResult Index()
        {
            var companyPhoto = db.CompanyPhoto.Include(c => c.Employer);
            return View(companyPhoto.ToList());
        }


        // GET: Control/CompanyPhotoes/Create
        public ActionResult Create()
        {
            ViewBag.EmployerId = new SelectList(db.Employers, "Id", "Firstname");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Photo,EmployerId")] CompanyPhoto companyPhoto)
        {
            if (ModelState.IsValid)
            {
                db.CompanyPhoto.Add(companyPhoto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmployerId = new SelectList(db.Employers, "Id", "Firstname", companyPhoto.EmployerId);
            return View(companyPhoto);
        }

        // GET: Control/CompanyPhotoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyPhoto companyPhoto = db.CompanyPhoto.Find(id);
            if (companyPhoto == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployerId = new SelectList(db.Employers, "Id", "Firstname", companyPhoto.EmployerId);
            return View(companyPhoto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Photo,EmployerId")] CompanyPhoto companyPhoto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(companyPhoto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmployerId = new SelectList(db.Employers, "Id", "Firstname", companyPhoto.EmployerId);
            return View(companyPhoto);
        }

        // GET: Control/CompanyPhotoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyPhoto companyPhoto = db.CompanyPhoto.Find(id);
            if (companyPhoto == null)
            {
                return HttpNotFound();
            }
            db.CompanyPhoto.Remove(companyPhoto);
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
