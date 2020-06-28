using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWebSite.Models.Classes;

namespace MyWebSite.Controllers
{
    public class BlogController : Controller
    {
        Context context = new Context();
        // GET: Blog
        public ActionResult Index()
        {
            var blog = context.Blogs.ToList();
            return View(blog);
        }
        public ActionResult BlogDetail(int id)
        {
            var blogFind = context.Blogs.Where(x => x.Id == id).ToList();
            return View(blogFind);
        }
    }
}