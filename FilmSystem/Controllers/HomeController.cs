using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilmSystem.Controllers
{
    public class HomeController : Controller
    {
        private Models.ApplicationDbContext db = new Models.ApplicationDbContext();


        public ActionResult Index()
        {
            var items = db.Movies;
            return View(items);
        }

      

        public ActionResult About()
        {
            ViewBag.Message = "Про нас";

            return View();
        }
                     

        public ActionResult UserAccMovie()
        {
            var items = db.Movies;
            return View(items);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AboutFilm(int item_id)
        {
            ViewBag.Message = "Про фільм";
            var Item = db.Movies.FirstOrDefault(x => x.Id == item_id);
            return View(Item);

        }
    }
}