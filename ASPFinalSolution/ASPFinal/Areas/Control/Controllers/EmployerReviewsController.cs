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
    public class EmployerReviewsController : Controller
    {
        private JoobsyDbContext db = new JoobsyDbContext();

        // GET: Control/EmployerReviews
        public ActionResult Index()
        {
            var employerReviews = db.EmployerReviews.Include(e => e.Candidate).Include(e => e.Employer);
            return View(employerReviews.ToList());
        }

        [HttpPost]
        public JsonResult Edit(int? id, bool status)
        {
            if (id == null)
            {
                return Json(new { res = true }, JsonRequestBehavior.AllowGet);
            }
            EmployerReview employerReview = db.EmployerReviews.Find(id);
            if (employerReview == null)
            {
                return Json(new { res = true }, JsonRequestBehavior.AllowGet);
            }
            employerReview.Satuts = status;
            db.SaveChanges();
            return Json(new { res = true }, JsonRequestBehavior.AllowGet);
        }

        // GET: Control/EmployerReviews/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployerReview employerReview = db.EmployerReviews.Find(id);
            if (employerReview == null)
            {
                return HttpNotFound();
            }
            return View(employerReview);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployerReview employerReview = db.EmployerReviews.Find(id);
            if (employerReview == null)
            {
                return HttpNotFound();
            }
            db.EmployerReviews.Remove(employerReview);
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
