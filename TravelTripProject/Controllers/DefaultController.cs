using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelTripProject.Models.Classes;
using System.Web.Mvc;

namespace TravelTripProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        BlogYorum by = new BlogYorum();
        public ActionResult Index()
        {
            return View(c.Blogs.OrderByDescending(x=>x.ID).Take(5).ToList());
        }

        public ActionResult About()
        {
            return View();
        }

        public PartialViewResult Partial1()
        {
            return PartialView(c.Blogs.OrderByDescending(x=>x.ID).Take(3).ToList());
        }

        public PartialViewResult Partial2()
        {
            return PartialView(c.Blogs.OrderByDescending(x => x.ID).Take(10).ToList());
        }

        public PartialViewResult Partial3()
        {
            by.Deger4 = c.Yorumlars.OrderByDescending(x => x.ID).Take(6).ToList();
            return PartialView(by);
        }
    }
}