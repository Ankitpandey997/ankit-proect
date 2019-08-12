using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testWebApi.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            ViewBag.Title = "home page";
            return View();
        }
        public ActionResult Showdata()
        {
            return View();

        }
    }
}