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
    public class BlogReviewsController : Controller
    {
        private JoobsyDbContext db = new JoobsyDbContext();

        // GET: Control/BlogReviews
        public ActionResult Index()
        {
            var blogReviews = db.BlogReviews.Include(b => b.Blog).Include(b => b.Candidate);
            return View(blogReviews.ToList());
        }

        // GET: Control/BlogReviews/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BlogReview blogReview = db.BlogReviews.Find(id);
            if (blogReview == null)
            {
                return HttpNotFound();
            }
            return View(blogReview);
        }

        [HttpPost]
        public JsonResult Edit(int? id,bool status)
        {
            if (id == null)
            {
                return Json(new { res = true }, JsonRequestBehavior.AllowGet);
            }
            BlogReview blogReview = db.BlogReviews.Find(id);
            if (blogReview == null)
            {
                return Json(new { res = true }, JsonRequestBehavior.AllowGet);
            }
            blogReview.Status = status;
            db.SaveChanges();
            return Json(new {res = true },JsonRequestBehavior.AllowGet);
        }

        // GET: Control/BlogReviews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BlogReview blogReview = db.BlogReviews.Find(id);
            if (blogReview == null)
            {
                return HttpNotFound();
            }
            db.BlogReviews.Remove(blogReview);
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
