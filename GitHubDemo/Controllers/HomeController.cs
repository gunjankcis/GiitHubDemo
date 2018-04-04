using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitHubDemo.Controllers
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

        public ActionResult LoginFeature()
        {
            ViewBag.Message = "This is a login feature message.";
            return View();
        }

        public ActionResult Master()
        {
            ViewBag.Message = "This is a master message.";
            return View();
        }
        public ActionResult SignUpFeature()
        {
            ViewBag.Message = "This is a Signup feature message.";
            return View();
        }
    }
}