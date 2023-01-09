using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace _2StepsForwardFoundation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Donate()
        {
            return View();
        }

        public ActionResult DonateSuccess()
        {
            return View();
        }

        public ActionResult DonateShare()
        {
            return View();
        }

        public ActionResult Events()
        {
            return View();
        }

        public ActionResult Resources()
        {
            return View();
        }
    }
}