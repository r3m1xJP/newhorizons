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
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search()
        {
            return View();
        }

        public ActionResult NewsDirectory()
        {
            return View();
        }

        public ActionResult NewsArticle(int id = 0)
        {
            ViewBag.Title = "Fran Welsh from Medix College Brantford wins the Woman of Excellence Award for Active Living and Wellness";

            ViewBag.NewsDate = "March 2, 2015";

            ViewBag.NewsBody = "We would like to congratulate Fran Welsh our Placement Supervisor for winning the Woman of " +

           "Excellence Award for Active Living and Wellness. Welsh has operated a fitness and wellness " +

            "consulting service for 20 years. She is known throughout the city and county for rehabilitation, " +

            "sport­specific training, health, fitness and wellness. She has been a columnist for Fit Brant " +

            "Magazine and a fitness expert on Rogers TV. Welsh is a placement co­ordinator and supervisor " +

            "at Medix College, and works with seniors and people with disabilities at the Boys' and Girls' " +

            "Club. She consults with clients of all ages and fitness levels to develop programs to help them " +

            "optimize health, recover from illness, prepare and recover from injury or surgery, prepare for " +

            "competition or address physical challenges or disabilities. Welsh consults with organizations " +

            "and fitness centres, nationally and internationally, to develop policies, procedures and plans " +

            "ensuring the appropriate purchase of equipment, optimal layout of workout areas and training of " +

            "fitness staff. Clients have included the Department of National Defence, Red Cross and a host " +

            "of fitness centres across Canada and the U.S.";

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> ApplyNow(FormCollection fc)
        {
            var formData = new FormUrlEncodedContent(fc.AllKeys.ToDictionary(k => k, v => fc[v]));

            using (var client = new HttpClient())
            {
                var response = await client.PostAsync("http://www1.campuslogin.com/Contacts/Web/ImportContactData.aspx", formData);

                if (response.IsSuccessStatusCode)
                {
                    ViewBag.Success = true;

                    try
                    {
                        using (var mailClient = new SmtpClient("smtp.gmail.com"))
                        {
                            mailClient.Credentials = new NetworkCredential("ccgactiveleads", "Medixcollege1");
                            mailClient.Port = 587;

                            var message = new MailMessage();

                            message.From = new MailAddress("ccgactiveleads@gmail.com", "MedixCollege.net");

                            message.To.Add(new MailAddress("activeleads@medixcollege.ca"));

                            message.Subject = "Apply Now Leads";

                            var stringArray = (from key in fc.AllKeys
                                               from value in fc.GetValues(key)
                                               select string.Format("{0}={1}", HttpUtility.UrlEncode(key), HttpUtility.UrlEncode(value))).ToArray();

                            message.Body = string.Join(",", stringArray);
                            message.IsBodyHtml = false;

                            mailClient.EnableSsl = true;
                            mailClient.Send(message);
                        }
                    }
                    catch (Exception ex)
                    {
                        ViewBag.Success = false;

                        ViewBag.ErrorMessage = ex.Message.ToString();
                    }
                }
                else
                {
                    ViewBag.Success = false;

                    ViewBag.ErrorMessage = "There was an error with your request. Please try again.";
                }

                return View();
            }
        }
    }
}