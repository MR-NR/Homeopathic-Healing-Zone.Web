using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HHZ.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }


        public ActionResult SearchResult()
        {


            return View();
        }


        public ActionResult HowItsWorks()
        {

            return View();
        }


        public ActionResult BlogPost()
        {

            return View();
        }


        public ActionResult BlogPostDetail()
        {

            return View();
        }


        public ActionResult DoctorDetail()
        {

            return View();
        }
    }
}