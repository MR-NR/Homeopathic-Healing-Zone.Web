using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HHZ.Areas.Doctor.Controllers
{
    public class HomeController : Controller
    {
        // GET: Doctor/Doctor
        
        public ActionResult Dashboard()
        {
            return View();
        }

        // GET: Profile Setting
        public ActionResult ProfileSetting()
        {
            return View();
        }

        // GET: Job Location
        public ActionResult JobLoction()
        {
            return View();
        }

        // GET: Private Messages
        public ActionResult PrivateMessages()
        {
            return View();
        }

        // GET: Appointments
        public ActionResult Appointment()
        {
            return View();
        }

        // GET: Appointments Setting
        public ActionResult AppointmentSetting()
        {
            return View();
        }

        // GET: Favorit Listing
        public ActionResult FavoritListing()
        {
            return View();
        }

        // GET: Invoice
        public ActionResult Invoice()
        {
            return View();
        }

        // GET: Update Package
        public ActionResult UpdatePackage()
        {
            return View();
        }

        // GET: Security Settings
        public ActionResult SecuritySettings()
        {
            return View();
        }

        // GET: Privacy Settings
        public ActionResult PrivacySettings()
        {
            return View();
        }
    }
}