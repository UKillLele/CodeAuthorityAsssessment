using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactUs.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Questions? Comments? Let us know!";
            return View();
        }

        [HttpPost]
        public ActionResult Index(string firstName, string lastName, string email, string telephone, string timeToCall)
        {
            ViewBag.Message = "Form submitted successfully - Thanks for contacting us!";
            return View();
        }
    }
}