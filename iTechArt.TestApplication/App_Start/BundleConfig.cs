using System.Web;
using System.Web.Optimization;

namespace iTechArtTestApplication
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

			bundles.Add(new ScriptBundle("~/bundles/calculate").Include(
					  "~/Scripts/Views/calculate.js"));
			bundles.Add(new ScriptBundle("~/bundles/depots").Include(
					  "~/Scripts/Views/depots.js"));
			bundles.Add(new ScriptBundle("~/bundles/requests").Include(
					  "~/Scripts/Views/requests.js"));
			bundles.Add(new ScriptBundle("~/bundles/weight").Include(
					  "~/Scripts/Views/weight.js"));
			bundles.Add(new ScriptBundle("~/bundles/drugUnitToDepot").Include(
					  "~/Scripts/Views/drugUnitToDepot.js"));
			bundles.Add(new ScriptBundle("~/bundles/jQueryTemplate").Include(
					  "~/Scripts/jQueryTemplate/jquery.tmpl.js"));
		}
    }
}
