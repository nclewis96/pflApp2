using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace pfl.Controllers
{
    public class OrderController : Controller
    {
        // /Order/
        // Page will provide Fields to allow the user to input information to 
        // Complete an order
        public ActionResult Index()
        {

            return View();
        }
    }
}
