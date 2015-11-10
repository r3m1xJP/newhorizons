using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedixCollege.Controllers
{
    public class ProgramsController : Controller
    {
        // GET: Programs
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

        public ActionResult ITOffice()
        {
            return View();
        }

        public ActionResult ITServiceTechnician()
        {
            return View();
        }

        public ActionResult ITServiceAdministrator()
        {
            return View();
        }

        public ActionResult ITHelpDeskAssociate()
        {
            return View();
        }

        public ActionResult ITEnterpriseProfessional()
        {
            return View();
        }

        public ActionResult AllPrograms()
        {
            ViewBag.SideHeader = "Test";
            ViewBag.SideSubHeader1 = "Test1";
            ViewBag.SideSubText1 = "Test2";
            ViewBag.SideSubHeader2 = "Test3";
            ViewBag.SideSubText2 = "Test4";
            ViewBag.SideSubHeader3 = "Test5";
            ViewBag.SideSubText3 = "Test6";

            return View();
        }
    }
}