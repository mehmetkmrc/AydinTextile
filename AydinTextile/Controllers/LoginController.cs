using AydinTextile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AydinTextile.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        AydinTextileDBEntities db = new Models.AydinTextileDBEntities();
        public ActionResult Index()
        {
            var model = db.Author.ToList();
            return View();
        }
    }
}