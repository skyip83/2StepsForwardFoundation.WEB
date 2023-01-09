using System.Web;
using System.Web.Optimization;

namespace _2StepsForwardFoundation
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery", "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.10.2.min.js").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate.min*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryunobtrusive").Include(
                        "~/Scripts/jquery.unobtrusive-ajax.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr", "https://cdn.jsdelivr.net/modernizr/2.8.3/modernizr.min.js").Include(
                      "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap", "http://ajax.aspnetcdn.com/ajax/bootstrap/3.3.6/bootstrap.min.js").Include(
                      "~/Scripts/bootstrap.min.js", "~/Scripts/respond.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css", "~/Content/jquery.sidr.light.min.css", "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/sidr", "http://cdn.jsdelivr.net/jquery.sidr/2.2.1/jquery.sidr.min.js").Include(
                      "~/Scripts/jquery.sidr.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/slick", "http://cdn.jsdelivr.net/jquery.slick/1.5.9/slick.min.js").Include(
                      "~/Scripts/slick.min.js"));

            bundles.Add(new StyleBundle("~/Content/slickcss").Include(
                      "~/Content/slick.css", "~/Content/slick-theme.css"));

            bundles.Add(new ScriptBundle("~/bundles/Home/Index").Include(
                      "~/Scripts/ViewModels/Home/IndexViewModel.js"));

            BundleTable.EnableOptimizations = true;
            bundles.UseCdn = true;
        }
    }
}
