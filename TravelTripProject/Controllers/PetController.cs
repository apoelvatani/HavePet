using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class PetController : Controller
    {
        Context c = new Context();
        // GET: Pet
        public ActionResult Index()
        {
            return View(c.Pets.ToList());
        }

        public ActionResult PetDetails(int id)
        {
            return View(c.Pets.Where(x => x.ID == id).ToList());
        }
    }
}