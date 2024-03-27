using ShoesStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace ShoesStore.Areas.Admin.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext dbContext = new ApplicationDbContext();
        // GET: Admin/Product
        public ActionResult Index()
        {
            var listProduct = dbContext.Shoes.Include(x => x.Category).ToList();
            return View(listProduct);
        }
    }
}