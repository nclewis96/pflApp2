using pfl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;

namespace pfl.Controllers
{
    public class ProductController : Controller
    {

        // /Product/
        // Page will use a GET request to the PFL test API to display all of the 
        // Products and the details of each one 
        public ActionResult Index()
        {

            Requester req = new Requester();
            List<ProductsJSON> products = req.GetAllProducts();
            ViewData["ProductList"] = products;
            return View();
        }
    }
}
