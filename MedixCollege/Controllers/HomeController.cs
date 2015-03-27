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
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var newsArticle = new NewsArticle();

            ViewBag.NewsArticles = newsArticle.Get().ToList();

            return View();
        }

        public ActionResult Search()
        {
            return View();
        }

        public ActionResult NewsDirectory()
        {
            var newsArticle = new NewsArticle();

            return View(newsArticle.Get().ToList());
        }

        public ActionResult NewsArticle(int id = 0)
        {
            if (id > 0)
            {
                var newsArticle = new NewsArticle(id);

                ViewBag.Title = newsArticle.NewsArticleDTO.Title;

                ViewBag.NewsDate = newsArticle.NewsArticleDTO.Date;

                ViewBag.NewsBody = newsArticle.NewsArticleDTO.Body;
            }

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