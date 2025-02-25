﻿using System.Web;
using System.Web.Optimization;

namespace ShoesStore
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/Theme_ShoesStore/css").Include(
                      "~/Content/Theme_ShoesStore/plugins/OwlCarousel2-2.2.1/owl.carousel.css",
                      "~/Content/Theme_ShoesStore/plugins/OwlCarousel2-2.2.1/owl.theme.default.css",
                      "~/Content/Theme_ShoesStore/plugins/font-awesome-4.7.0/css/font-awesome.min.css",
                      "~/Content/Theme_ShoesStore/styles/bootstrap4/bootstrap.min.css",
                      "~/Content/Theme_ShoesStore/plugins/OwlCarousel2-2.2.1/animate.css",
                      "~/Content/Theme_ShoesStore/styles/main_styles.css",
                      "~/Content/Theme_ShoesStore/styles/responsive.css"));

            bundles.Add(new ScriptBundle("~/bundles/Theme_ShoesStore/js").Include(
                      "~/Content/Theme_ShoesStore/js/jquery-3.2.1.min.js",
                      "~/Content/Theme_ShoesStore/styles/bootstrap4/popper.js",
                      "~/Content/Theme_ShoesStore/styles/bootstrap4/bootstrap.min.js",
                      "~/Content/Theme_ShoesStore/plugins/Isotope/isotope.pkgd.min.js",
                      "~/Content/Theme_ShoesStore/plugins/OwlCarousel2-2.2.1/owl.carousel.js",
                      "~/Content/Theme_ShoesStore/plugins/easing/easing.js",
                      "~/Content/Theme_ShoesStore/js/custom.js"));
        }
    }
}
