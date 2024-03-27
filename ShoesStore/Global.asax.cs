using ShoesStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ShoesStore
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //List<Product> products = new List<Product>()
            //{
            //    new Product(){Id=1, Hang= "-20%", Price=450, Title="Converse", Image="/Content/Theme_ShoesStore/images/product_1.png"},
            //    new Product(){Id=2, Hang= "-10%", Price=520, Title="MLB", Image="/Content/Theme_ShoesStore/images/product_2.png"},
            //    new Product(){Id=3, Hang= "-30%", Price=390, Title="Adidas", Image="/Content/Theme_ShoesStore/images/product_3.png"},
            //    new Product(){Id=4, Hang= "-25%", Price=420, Title="Nike", Image="/Content/Theme_ShoesStore/images/product_4.png"}
            //};
            //Application["listProduct"] = products; 
        }
    }
}
