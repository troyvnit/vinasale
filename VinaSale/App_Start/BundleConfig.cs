using System.Web;
using System.Web.Optimization;

namespace VinaSale
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

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
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/BO/kendo").Include(
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/bootstrap-tagsinput.min.js",
                        "~/Scripts/maps.js",
                        "~/ViewLibraries/kendo/Scripts/2013.3.1119/kendo.all.min.js",
                        "~/ViewLibraries/kendo/Scripts/2013.3.1119/kendo.aspnetmvc.min.js",
                        "~/ViewLibraries/kendo/Scripts/2013.3.1119/cultures/kendo.culture.vi-VN.min.js"));

            bundles.Add(new StyleBundle("~/Content/BO/kendo").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/bootstrap-tagsinput.css",
                      "~/ViewLibraries/kendo/Content/2013.3.1119/kendo.common-bootstrap.min.css",
                      "~/ViewLibraries/kendo/Content/2013.3.1119/kendo.bootstrap.min.css",
                      "~/ViewLibraries/kendo/Content/2013.3.1119/styles.css"));

            bundles.Add(new StyleBundle("~/Content/FO").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/buttons.css",
                      "~/Content/site.css",
                      "~/Content/bootstrap-responsive.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/FO").Include(
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/jquery.masonry.min.js",
                      "~/Scripts/base.js"));
        }
    }
}
