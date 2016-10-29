using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pokoje.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Calendar()
        {
            ViewBag.Message = "Kalendarz Eventów";

            return View();
        }
        public ActionResult List()
        {
            ViewBag.Message = "Lista Rezerwacji";

            return View();
        }


    }
}