using AydinTextile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AydinTextile.Controllers
{
    public class AuthorAdminController : Controller
    {
        // GET: AuthorAdmin
        AydinTextileDBEntities db = new Models.AydinTextileDBEntities();
        public ActionResult Index()
        {
            return View(db.Author.ToList());
        }
    }
}