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
    public class AdminManagersController : Controller
    {
        private JoobsyDbContext db = new JoobsyDbContext();

        // GET: Control/AdminManagers
        public ActionResult Index()
        {
            return View(db.AdminManagers.ToList());
        }

        // GET: Control/AdminManagers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdminManager adminManager = db.AdminManagers.Find(id);
            if (adminManager == null)
            {
                return HttpNotFound();
            }
            return View(adminManager);
        }


        // GET: Control/AdminManagers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdminManager adminManager = db.AdminManagers.Find(id);
            if (adminManager == null)
            {
                return HttpNotFound();
            }
            return View(adminManager);
        }

        // POST: Control/AdminManagers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Firstname,Lastname,Email,Password,Token,Status,Photo,AdminPosition")] AdminManager adminManager)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adminManager).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adminManager);
        }

        // GET: Control/AdminManagers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdminManager adminManager = db.AdminManagers.Find(id);
            if (adminManager == null)
            {
                return HttpNotFound();
            }
            db.AdminManagers.Remove(adminManager);
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
