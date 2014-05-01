using System.Web;
using System.Web.Optimization;

namespace Hivyppp
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery.min.js",
                        "~/Scripts/jquery.migrate.js",
                        "~/Scripts/jquery.magnific-popup.min.js",
                        "~/Scripts/jquery.imagesloaded.min.js",
                        "~/Scripts/jquery.isotope.min.js",
                        "~/Scripts/retina-1.1.0.min.js",
                        "~/Scripts/jquery.nicescroll.min.js",
                        "~/Scripts/script.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                    "~/Content/bootstrap.css",
                    "~/Content/magnific-popup.css",
                    "~/Content/font-awesome.css",
                    "~/Content/flexslider.css",
                    "~/Content/style.css",
                    "~/Content/responsive.css",
                    "~/Content/site.css"));
        }
    }
}
