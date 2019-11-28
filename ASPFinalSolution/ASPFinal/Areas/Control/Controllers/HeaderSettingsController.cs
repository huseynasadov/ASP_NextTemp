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
    public class HeaderSettingsController : Controller
    {
        private JoobsyDbContext db = new JoobsyDbContext();

        // GET: Control/HeaderSettings
        public ActionResult Index()
        {
            return View(db.HeaderSetting.ToList());
        }


        // GET: Control/HeaderSettings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HeaderSetting headerSetting = db.HeaderSetting.Find(id);
            if (headerSetting == null)
            {
                return HttpNotFound();
            }
            return View(headerSetting);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Photo,Page")] HeaderSetting headerSetting)
        {
            if (ModelState.IsValid)
            {
                db.Entry(headerSetting).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(headerSetting);
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
