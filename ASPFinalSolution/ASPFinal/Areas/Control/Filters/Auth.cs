using ASPFinal.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPFinal.Areas.Control.Filters
{
    public class Auth : ActionFilterAttribute
    {
        private readonly JoobsyDbContext _db;

        public Auth()
        {
            _db = new JoobsyDbContext();
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies.Get("token");

            if (cookie == null)
            {
                filterContext.Result = new RedirectResult("~/control");
                return;
            }

            var admin = _db.AdminManagers.FirstOrDefault(a => a.Token == cookie.Value);

            if (admin == null)
            {
                filterContext.Result = new RedirectResult("~/control");
                return;
            }

            filterContext.Controller.ViewBag.admin = admin;
            base.OnActionExecuting(filterContext);
        }
    }
}