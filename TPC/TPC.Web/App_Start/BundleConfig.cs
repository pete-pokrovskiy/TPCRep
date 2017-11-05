using System.Diagnostics;
using System.Web;
using System.Web.Optimization;

namespace TPC.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                "~/Scripts/jquery.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/mixer.js",
                "~/Scripts/wow.min.js",
                "~/Scripts/jquery.appear.js",
                "~/Scripts/prettyPhoto.js",
                "~/Scripts/jquery.magnific-popup.js",
                 "~/Scripts/app/theme.js",
                "~/Scripts/app/app.jquery.js"));

            //TODO: разобраться с подгрузкой изображений для случая публикации в Release и использовании бандлов
            //bundles.Add(new StyleBundle("~/Content/css_images").Include("~/Content/Styles/theme_color.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/Styles/animate.css", 
                "~/Content/Styles/bootstrap.css",
                "~/Content/Styles/font-awesome.css",
                "~/Content/Styles/iconmoon.css",
                "~/Content/Styles/preset.css",
                "~/Content/Styles/prettyPhoto.css",
                "~/Content/Styles/responsive.css",
                "~/Content/Styles/magnific-popup.css",
                "~/Content/Styles/flaticon.css",
               "~/Content/Styles/iconmoon-custom.css",
                "~/Content/Styles/site.css",
                 "~/Content/Styles/theme_color.css"
                ));

        }
    }
}
