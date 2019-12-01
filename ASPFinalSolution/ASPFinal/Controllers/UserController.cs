using ASPFinal.Models;
using ASPFinal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace ASPFinal.Controllers
{
    public class UserController : BaseController
    {
        // GET: User
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Register(User user)
        {
            if (user==null)
            {
                return Json(new { status = false }, JsonRequestBehavior.AllowGet);
            }
            if (ModelState.IsValid)
            {
                if (_db.Users.FirstOrDefault(a => a.Email == user.Email)==null)
                {
                    user.Token = Guid.NewGuid().ToString();
                    user.Password = Crypto.HashPassword(user.Password);
                    _db.Users.Add(user);
                    _db.SaveChanges();

                    HttpCookie cookie = new HttpCookie("tokenUser", user.Token)
                    {
                        HttpOnly = true,
                        Expires = DateTime.MinValue
                    };

                    Response.Cookies.Add(cookie);
                    User u = _db.Users.FirstOrDefault(model => model.Token == user.Token);
                    if (u.UserPosition == true)
                    {
                        Candidate candidate = new Candidate
                        {
                            UserId = u.Id
                        };
                        _db.Candidates.Add(candidate);
                        _db.SaveChanges();
                    }
                    else
                    {
                        Employer employer = new Employer
                        {
                            UserId = u.Id
                        };
                        _db.Employers.Add(employer);
                        _db.SaveChanges();
                    }

                    return Json(new { status = true }, JsonRequestBehavior.AllowGet);
                }
            }

            return Json(new { status = false }, JsonRequestBehavior.AllowGet);
        }
        
        [HttpPost]
        public JsonResult Login(UserVM userVM)
        {
            if (ModelState.IsValid)
            {
                User admin = _db.Users.FirstOrDefault(a => a.Username == userVM.Username);
                if (admin != null && Crypto.VerifyHashedPassword(admin.Password, userVM.Password))
                {
                    admin.Token = Guid.NewGuid().ToString();

                    _db.SaveChanges();

                    HttpCookie cookie = new HttpCookie("tokenUser", admin.Token)
                    {
                        HttpOnly = true,
                        Expires = DateTime.Now.AddYears(1)
                    };

                    Response.Cookies.Add(cookie);
                    ViewBag.User = admin;
                    return Json(new { status = true }, JsonRequestBehavior.AllowGet);
                }

            }
            return Json(new { status = false }, JsonRequestBehavior.AllowGet);
        }
    }
}