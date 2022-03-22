using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Misison12GroupProject.Models;
using Misison12GroupProject.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Misison12GroupProject.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext contextInfo { get; set; }

        public HomeController(ApplicationContext data)
        {
            contextInfo = data;

        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            var AppointmentsList = contextInfo.appointments
                .Where(a => a.Taken == false)
                .ToList();
            return View(AppointmentsList);
        }

        //public IActionResult SignUp(int id)
        //{
        //    return View(new AppointmentsViewModel
        //    {
        //        Appointment = contextInfo.appointments.Single(x => x.AppointmentID == id)
        //    });
        //}

        [HttpPost]
        public IActionResult SignUp(AppointmentsViewModel avm, int id)
        {
            if (ModelState.IsValid)
            {
                contextInfo.appointments.Single(x => x.AppointmentID == id).Taken = true;
                contextInfo.appointments.Add(avm.Appointment);
                contextInfo.SaveChanges();
                return RedirectToAction("Confirmation");
            }
            else
            {
                return View(new AppointmentsViewModel
                {
                    Appointment = contextInfo.appointments.Single(x => x.AppointmentID == id)
                });
            }
        }
        
        public IActionResult Appointments()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddAppointment(int id)
        {
            ViewBag.id = id;

            ViewBag.appointments = contextInfo.appointments.ToList();

            var x = new GroupInfo();

            return View(x);

        }

        [HttpPost]
        public IActionResult AddAppointment(GroupInfo gi)
        {
            if (ModelState.IsValid)
            {
                contextInfo.Add(gi);
                contextInfo.SaveChanges();
                return View("Confirmation");
            }
            else // If Invalid
            {
                ViewBag.group = contextInfo.group.ToList();
                return View();
            }
            
        }

    }
}

