using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GearsStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyRecommendations()
        {
            ViewBag.Message = "My Daily Recommendations.";

            return View();
        }

        public ActionResult profile()
        {
            ViewBag.Message = "My Profile.";

            return View();
        }
    }
}