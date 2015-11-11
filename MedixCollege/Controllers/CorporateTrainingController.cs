using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedixCollege.Controllers
{
    public class CorporateTrainingController : Controller
    {
        // GET: All Campuses
        public ActionResult Index()
        {
            return View();
        }

        // GET: Brampton
        public ActionResult CorporatePromotions()
        {
            return View();
        }
    }
}