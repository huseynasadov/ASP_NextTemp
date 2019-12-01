using ASPFinal.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPFinal.Filter
{
    public class AuthFilter:ActionFilterAttribute
    {
        private readonly JoobsyDbContext _db;

        public AuthFilter()
        {
            _db = new JoobsyDbContext();
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies.Get("tokenUser");

            if (cookie == null)
            {
                return;
            }

            var user = _db.Users.FirstOrDefault(a => a.Token == cookie.Value);

            if (user == null)
            {
                return;
            }

            filterContext.Controller.ViewBag.User = user;
            base.OnActionExecuting(filterContext);
        }
    }
}