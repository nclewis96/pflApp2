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
        // GET: /<controller>/
        public ActionResult Index()
        {
            return View();
        }

        // GET: /pflApp/Products/
        public string ProductList()
        {
            return "Bleh";
        }
    }
}
