using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            List<String> products = new List<string>(3);
            products.Add("Laptop");
            products.Add("Tablet");
            products.Add("Desktop");
            return View(products);
        }

        public ActionResult Details(String product)
        {
            ViewBag.Message = $"You selected product: [{product}]";

            return View();
        }
    }
}