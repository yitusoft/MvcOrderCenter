using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderCenter.Controllers
{
    public class HomeController : Controller
    {
        // GET: Homr
        public ActionResult Index()
        {
            return View();
        }
    }
}