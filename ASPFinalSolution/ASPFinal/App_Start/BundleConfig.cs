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
                        "~/Public/js/mdb.min.js",
                        "~/Public/js/main.js"));


            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/Public/css/mdb.min.css",
                      "~/Public/css/style.css",
                      "~/Public/css/responsive.css"));


        }
    }
}
