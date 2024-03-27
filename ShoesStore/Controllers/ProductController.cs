using ShoesStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static ShoesStore.Models.CartItem;

namespace ShoesStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext dbContext = new ApplicationDbContext();
        // GET: Product
        public ActionResult Index()
        {
            var listProduct = dbContext.Shoes.ToList();
            return View("TrangChu",listProduct);
        }
        public ActionResult Details(int id)
        {
            var listProduct = dbContext.Shoes.FirstOrDefault(x => x.Id == id);
            return View("Details", listProduct);
        }

        private int isExist(int id)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Product.Id.Equals(id))
                    return i;
            return -1;
        }

        public ActionResult UpdateCart()
        {
            int productId = int.Parse(Request.Form["productId"]);
            int quantity = int.Parse(Request.Form["quantity"]);
            List<Item> cart = (List<Item>)Session["cart"];
            int index = isExist(productId);
            if (index != -1)
            {
                cart[index].Quantity = quantity;
            }
            Session["cart"] = cart;
            return RedirectToAction("ViewCart");
        }

        public ActionResult AddCart(int id)
        {
            Shoes product = dbContext.Shoes.Find(id);
            if (Session["cart"] == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item { Product = product, Quantity = 1 });
                Session["cart"] = cart;
            }
            else
            {
                List<Item> cart = (List<Item>)Session["cart"];
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Item { Product = product, Quantity = 1 });
                }
                Session["cart"] = cart;
            }
            return RedirectToAction("ViewCart");
        }

        public ActionResult ViewCart()
        {
            return View();
        }
    }
}