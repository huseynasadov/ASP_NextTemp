using System.Web;
using System.Web.Optimization;

namespace ASPFinal
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/javascript").Include(
                        "~/Public/js/bootstrap.bundle.min.js",
                        "~/Public/js/jquery.easing.min.js",
                        "~/Public/js/plugins.js",
                        "~/Public/js/selectize.min.js",
                        "~/Public/js/jquery.nice-select.min.js",
                        "~/Public/js/owl.carousel.min.js",
                        "~/Public/js/app.js",
                        "~/Public/js/home.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/Jquery").Include(
                       "~/Public/js/jquery.min.js"));

            bundles.Add(new StyleBundle("~/bundles/style").Include(
                      "~/Public/css/bootstrap.min.css",
                      "~/Public/css/materialdesignicons.min.css",
                      "~/Public/css/fontawesome.css",
                      "~/Public/css/selectize.css",
                      "~/Public/css/nice-select.css",
                      "~/Public/css/owl.carousel.css",
                      "~/Public/css/owl.theme.css",
                      "~/Public/css/owl.transitions.css",
                      "~/Public/css/style.css"
                      ));

        }
    }
}
