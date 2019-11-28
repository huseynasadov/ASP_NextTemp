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
    public class EmployersController : Controller
    {
        private JoobsyDbContext db = new JoobsyDbContext();

        // GET: Control/Employers
        public ActionResult Index()
        {
            return View(db.Employers.ToList());
        }

        // GET: Control/Employers/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "Id,Firstname,Lastname,Slug,Address,Rate,PhotoUpload,isVerified,CompanyName,CompanyAdress,CompanyPhone,CompanyWebsite,CompanyEmail,Empl0yers,Type,ExperienceDate,minSalary,maxSalary,Followers,Overview,Services,CreatedAt,Status")] Employer employer)
        {
            if (employer.PhotoUpload != null)
            {
                try
                {
                    employer.Photo = FileManager.Upload(employer.PhotoUpload);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("PhotoUpload", e.Message);
                }
            }
            if (ModelState.IsValid)
            {
                employer.Slug = employer.Firstname.ToLower() + "-" + employer.Lastname.ToLower();
                employer.CreatedAt = DateTime.Now;
                db.Employers.Add(employer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employer);
        }

        // GET: Control/Employers/Edit/5
        public ActionResult Edit(string slug)
        {
            if (slug == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employer employer = db.Employers.FirstOrDefault(e=>e.Slug==slug);
            if (employer == null)
            {
                return HttpNotFound();
            }
            return View(employer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "Id,Firstname,Lastname,Slug,Address,Rate,Photo,PhotoUpload,isVerified,CompanyName,CompanyAdress,CompanyPhone,CompanyWebsite,CompanyEmail,Empl0yers,Type,ExperienceDate,minSalary,maxSalary,Followers,Overview,Services,CreatedAt,Status")] Employer employer)
        {
            if (employer.PhotoUpload != null)
            {
                try
                {
                    employer.Photo = FileManager.Upload(employer.PhotoUpload);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("PhotoUpload", e.Message);
                }
            }
            if (ModelState.IsValid)
            {
                employer.Slug = employer.Firstname.ToLower() + "-" + employer.Lastname.ToLower();
                employer.CreatedAt = DateTime.Now;
                db.Entry(employer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employer);
        }

        // GET: Control/Employers/Delete/5
        public ActionResult Delete(string slug)
        {
            if (slug == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employer employer = db.Employers.FirstOrDefault(e=>e.Slug== slug);
            if (employer == null)
            {
                return HttpNotFound();
            }
            db.Employers.Remove(employer);
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
