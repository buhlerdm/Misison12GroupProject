using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Misison12GroupProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Misison12GroupProject.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext appContext { get; set; }
        public HomeController(ApplicationContext app)
        {
            appContext = app;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult Appointments()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddAppointment()
        {
            ViewBag.group = appContext.group.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AddAppointment(Appointment apt)
        {
            return View("Confirmation", apt);
        }

    }
}

