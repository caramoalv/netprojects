using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPNETMVC.Models;

namespace ASPNETMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var persona = new Persona();
            return View(persona);
        }
        [HttpPost]
        public ActionResult Index(Persona p) {
            return View(p);
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
    }
}