using System.Web;
using System.Web.Optimization;

namespace Angular4DotNetWebAPI
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            //ANGULAR LIBRARY START
            bundles.Add(new ScriptBundle("~/bundles/angular_src").Include(
                    "~/Scripts/angular_src/angular.min.js",
                    "~/Scripts/angular_src/angular-route.min.js",
                    "~/Scripts/angular_src/angular-resource.min.js",
                    "~/Scripts/angular_src/angular-ui/ui-bootstrap.min.js"
                    ));
            //ANGULAR LIBRARY END

            //ANGULAR APP Modules START
            bundles.Add(new ScriptBundle("~/bundles/app").IncludeDirectory(
                    "~/angular_app/", "*.js", true));

            //bundles.Add(new ScriptBundle("~/bundles/app_minsafed").Include(
            //       "~/App_Build/app_minsafed.js"));

            bundles.Add(new ScriptBundle("~/bundles/app_minsafed").IncludeDirectory(
                   "~/App_Build/", "*.js", true));
            //ANGULAR APP Modules END

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/Bootstrap/bootstrap-slate.min.css",
                      "~/Content/Bootstrap/ui-bootstrap-csp.css",
                      "~/Content/site.css"));

        }
    }
}
