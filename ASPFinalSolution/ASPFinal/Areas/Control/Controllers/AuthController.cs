using ASPFinal.Areas.Control.Models;
using ASPFinal.DAL;
using ASPFinal.Helpers;
using ASPFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace ASPFinal.Areas.Control.Controllers
{
    public class AuthController : Controller
    {
        private readonly JoobsyDbContext _db;

        public AuthController()
        {
            _db = new JoobsyDbContext();
        }
        // GET: Control/Auth
        public ActionResult Index()
        {
            HttpCookie cookie = Request.Cookies.Get("token");
            if (cookie == null)
            {
                return View();
            }
            var admin = _db.AdminManagers.FirstOrDefault(a => a.Token == cookie.Value);

            if (admin != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginVM login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }
            AdminManager admin = _db.AdminManagers.FirstOrDefault(a => a.Email == login.Email);
            if (admin != null && Crypto.VerifyHashedPassword(admin.Password, login.Password))
            {
                admin.Token = Guid.NewGuid().ToString();

                _db.SaveChanges();

                HttpCookie cookie = new HttpCookie("token", admin.Token)
                {
                    HttpOnly = true,
                    Expires = login.RememberMe ? DateTime.Now.AddYears(1) : DateTime.MinValue
                };

                Response.Cookies.Add(cookie);

                return RedirectToAction("index", "Home");
            }

            ModelState.AddModelError("", "E-mail or Password Wrong !");

            return View(login);
        }

        // Register
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(AdminManager admin)
        {
            if (!ModelState.IsValid)
            {
                return View(admin);
            }
            if (_db.AdminManagers.Any(a => a.Email == admin.Email))
            {
                ModelState.AddModelError("Email", "this email registred check another");
                admin.Email = "";
                return View(admin);
            }
            try
            {
                admin.Photo = FileManager.Upload(admin.PhotoUpload);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("PhotoUpload", e.Message);
                return View();
            }
            admin.AdminPosition = AdminPosition.Subadmin;
            admin.Token = Guid.NewGuid().ToString();
            admin.Status = true;
            admin.Password = Crypto.HashPassword(admin.Password);
            _db.AdminManagers.Add(admin);
            _db.SaveChanges();

            return RedirectToAction("index", "Home");
        }

        // Logout
        public ActionResult Logout()
        {
            HttpCookie cookie = Request.Cookies.Get("token");

            if (cookie == null)
            {
                return RedirectToAction("index");
            }

            AdminManager admin = _db.AdminManagers.FirstOrDefault(u => u.Token == cookie.Value);

            if (admin == null)
            {
                Response.Cookies["token"].Expires = DateTime.Now.AddDays(-1);

                return RedirectToAction("index");
            }

            admin.Token = null;
            _db.SaveChanges();

            Response.Cookies["token"].Expires = DateTime.Now.AddDays(-1);

            return RedirectToAction("index");
        }
    }
}