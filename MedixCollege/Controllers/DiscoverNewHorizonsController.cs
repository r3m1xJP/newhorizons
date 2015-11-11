using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedixCollege.Controllers
{
    public class DiscoverNewHorizonsController : Controller
    {
        // GET: DiscoverMedix
        public ActionResult Index()
        {
            ViewBag.HeroText = "";
            ViewBag.BodyHeaderText = "";

            ViewBag.SideHeader = "";
            ViewBag.SideSubHeader1 = "";
            ViewBag.SideSubText1 = "";
            ViewBag.SideSubHeader2 = "";
            ViewBag.SideSubText2 = "";
            ViewBag.SideSubHeader3 = "";
            ViewBag.SideSubText3 = "";

            return View();
        }

        // GET: History
        public ActionResult History()
        {
            return View();
        }

        // GET: Mission
        public ActionResult Mission()
        {
            return View();
        }

        // GET: Accreditation
        public ActionResult Accreditation()
        {
            return View();
        }

        public ActionResult Associations()
        {
            return View();
        }

        public ActionResult CareersAtNewHorizons()
        {
            return View();
        }
    }
}