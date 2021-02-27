using APFinal2202.Services;
using System.Web.Optimization;

namespace APFinal2202
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            var scriptBundle = new ScriptBundle("~/bundles/Scripts")
                .Include("~/Scripts/jquery-{version}.js")
                .Include("~/Scripts/jquery.validate*")
                .Include("~/Scripts/bootstrap.js")
                .Include("~/Scripts/dateTimePicker/jquery.datetimepicker.full.js")
                .Include("~/Scripts/dateTimePicker/jquery.datetimepicker.js")
                .Include("~/Scripts/libs/material-components-web.min.js")
                .Include("~/Scripts/libs/scripts.js")
                .Include("~/Scripts/libs/site.js")
                .Include("~/Scripts/libs/swiper.min.js");
            scriptBundle.Orderer = new AsIsBundleOrdered();
            bundles.Add(scriptBundle);

            bundles.Add(new ScriptBundle("~/bundles/modernizr")
                .Include("~/Scripts/modernizr-*"));

            var styleBundle = new StyleBundle("~/bundles/css")
                .Include("~/Content/css/bootstrap.min.css")
                .Include("~/Content/css/site.css")
                .Include("~/Content/bootstrap-theme.css")
                .Include("~/Content/css/libs/swiper.min.css")
                .Include("~/Content/css/libs/material-components-web.min.css")
                .Include("~/Content/css/style.css")
                .Include("~/Content/css/skins/blue.css")
                .Include("~/Content/css/responsive.css");
            styleBundle.Orderer = new AsIsBundleOrdered();
            bundles.Add(styleBundle);

            BundleTable.EnableOptimizations = true;
        }
    }
}
