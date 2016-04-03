using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoeShop.Controllers
{
    public class PageController : Controller
    {
        WebService1 wsv = new WebService1();
        // GET: Page
        public ActionResult Index()
        {
            return View();
        }
       
    }
}