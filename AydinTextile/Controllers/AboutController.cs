using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AydinTextile.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            ViewBag.Title = "Aydın Tekstil | Hakkımızda";
            return View();
        }
    }
}