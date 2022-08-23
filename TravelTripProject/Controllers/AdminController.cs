using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        // GET: Admin
        [Authorize]
        public ActionResult Index()
        {
            return View(c.Blogs.ToList());
        }

        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniBlog(Blog blog)
        {
            c.Blogs.Add(blog);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogSil(int id)
        {
            c.Blogs.Remove(c.Blogs.Find(id));
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogGetir(int id)
        {
            return View("BlogGetir", c.Blogs.Find(id));
        }

        public ActionResult BlogGuncelle(Blog blog)
        {
            var blogg = c.Blogs.Find(blog.ID);
            blogg.Baslik = blog.Baslik;
            blogg.Tarih = blog.Tarih;
            blogg.BlogImage = blog.BlogImage;
            blogg.Aciklama = blog.Aciklama;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YorumListele()
        {
            return View(c.Yorumlars.ToList());
        }

        public ActionResult YorumSil(int id)
        {
            c.Yorumlars.Remove(c.Yorumlars.Find(id));
            c.SaveChanges();
            return RedirectToAction("YorumListele");
        }

        public ActionResult YorumGetir(int id)
        {
            return View("YorumGetir" , c.Yorumlars.Find(id));
        }

        public ActionResult YorumGuncelle(Yorumlar y)
        {
            Yorumlar yrm = c.Yorumlars.Find(y.ID);
            yrm.KullaniciAdi = y.KullaniciAdi;
            yrm.Mail = y.Mail;
            yrm.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListele");
        }
    }
}