using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWebSite.Models.Classes;

namespace MyWebSite.Controllers
{
    public class AboutController : Controller
    {
        // GET: About

        Context context = new Context();
        public ActionResult Index()
        {
            var aboutus = context.Abouts.ToList();
            return View(aboutus);
        }
    }
}