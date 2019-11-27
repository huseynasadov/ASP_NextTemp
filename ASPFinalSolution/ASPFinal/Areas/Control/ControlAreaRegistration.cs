using System.Web.Mvc;

namespace ASPFinal.Areas.Control
{
    public class ControlAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "control";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "control_default",
                "control/{controller}/{action}/{id}",
                new { controller = "Auth", action = "Index", id = UrlParameter.Optional },
                new string[] {"ASPFinal.Areas.Control.Controllers"}
            );
        }
    }
}