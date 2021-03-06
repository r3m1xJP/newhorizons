﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedixCollege.Controllers
{
    public class CertificatesController : Controller
    {
        // GET: Certificates
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

        // GET: Abel-Dent
        public ActionResult AbelDent()
        {
            return View();
        }

        // GET: Basic Wound Treatment
        public ActionResult BasicWoundTreatment()
        {
            return View();
        }

        // GET: Certificates Continuing Education
        public ActionResult CertificatesContinuingEducation()
        {
            return View();
        }

        // GET: Electrocardiogram
        public ActionResult Electrocardiogram()
        {
            return View();
        }

        // GET: Emotional First Aid
        public ActionResult EmotionalFirstAid()
        {
            return View();
        }

        // GET: English Second Language
        public ActionResult EnglishSecondLanguage()
        {
            return View();
        }

        // GET: English Skills Healthcare Workers
        public ActionResult EnglishSkillsHealthcareWorkers()
        {
            return View();
        }

        // GET: First Aid CPR
        public ActionResult FirstAidCPR()
        {
            return View();
        }

        // GET: Food Handler Safety
        public ActionResult FoodHandlerSafety()
        {
            return View();
        }

        // GET: Home Child Care Management
        public ActionResult HomeChildCareManagement()
        {
            return View();
        }

        // GET: Intramuscular Injections
        public ActionResult IntramuscularInjections()
        {
            return View();
        }

        // GET: Introduction Developmental Disabilities Services
        public ActionResult IntroductionDevelopmentalDisabilitiesServices()
        {
            return View();
        }

        // GET: Introduction Swedish Massage
        public ActionResult IntroductionSwedishMassage()
        {
            return View();
        }

        // GET: Mental Health Addictions
        public ActionResult MentalHealthAddictions()
        {
            return View();
        }

        // GET: Phlebotomy
        public ActionResult Phlebotomy()
        {
            return View();
        }

        // GET: Soft Tissue Back Injury Prevention
        public ActionResult SoftTissueBackInjuryPrevention()
        {
            return View();
        }

        // GET: Urinalysis
        public ActionResult Urinalysis()
        {
            return View();
        }

        // GET: All Certificates
        public ActionResult AllCertificates()
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

        // GET: Medix Online
        public ActionResult MedixOnline()
        {
            return View();
        }
    }
}