using ASPFinal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPFinal.Controllers
{
    public class ContactController : BaseController
    {
        // GET: Contact
        public ActionResult Index()
        {
            ContactVM model = new ContactVM {
                Setting=ViewBag.Setting,
                breadcrumb=new Breadcrumb {
                    Title="Contact Us",
                    Path=new Dictionary<string, string> {
                        {ViewBag.Setting.LogoName,Url.Action("index","home")},
                        { "Contact",null}
                    }
                },
                HeaderSetting=_db.HeaderSetting.FirstOrDefault(h=>h.Page==Models.Page.Contact)
            };
            return View(model);
        }
    }
}