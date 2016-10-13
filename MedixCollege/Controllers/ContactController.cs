using MedixCollege.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MedixCollege.Controllers
{
    public class ContactController : Controller
    {
        public ContactController()
        {
        }

        // GET: MedixOnline
        public ActionResult Index()
        {
            return View();
        }

        // GET: Pages
        public ActionResult TorontoCampus()
        {
            return View();
        }

        public ActionResult BramptonCampus()
        {
            return View();
        }

        public ActionResult ScarboroughCampus()
        {
            return View();
        }
    }
}