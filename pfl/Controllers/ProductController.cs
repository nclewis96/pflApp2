using pfl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;
using System.Threading.Tasks;


namespace pfl.Controllers
{
    public class ProductController : Controller
    {

        // /Product/
        // Page will use a GET request to the PFL test API to display all of the 
        // Products and the details of each one 
        public async Task<ActionResult> Index()
        {

            Requester req = new Requester();
            List<ProductsJSON> products = (await Requester.GetAllProducts()).Results.ProductList;
            ViewData["ProductList"] = products;
            return View();
        }
    }
}
