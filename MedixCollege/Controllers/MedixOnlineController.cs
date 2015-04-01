using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedixCollege.Controllers
{
    public class MedixOnlineController : Controller
    {
        // GET: MedixOnline
        public ActionResult Index()
        {
            return View();
        }

        // GET: Schedules And Fees
        public ActionResult SchedulesAndFees()
        {
            return View();
        }

        // GET: ELearning
        public ActionResult ELearning()
        {
            return View();
        }

        // GET: Advantages
        public ActionResult Advantages()
        {
            return View();
        }

        public ActionResult ContactMedixOnline()
        {
            return View();
        }

    }
}