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
        public IActionResult SignUp(int id)
        {
            var AppointmentsList = contextInfo.appointments
                .Where(a => a.Taken == false)
                .ToList();
            return View(AppointmentsList);
        }

        public IActionResult Appointments()
        {
            ViewBag.APP = contextInfo.appointments.ToList();

            var appointments = contextInfo.group.ToList();
            return View(appointments);
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

                List<Appointment> results = contextInfo.appointments.Where(a => a.AppointmentID == gi.AppointmentID).ToList();
                foreach(Appointment app in results)
                {
                    app.Taken = true;
                }
                contextInfo.SaveChanges();

                return View("Confirmation", gi);
            }
            else // If Invalid
            {
                ViewBag.group = contextInfo.group.ToList();
                return View();
            }
            
        }


        public IActionResult Edit(int GroupId)
        {
            ViewBag.appointments = contextInfo.appointments.ToList();

            var group = contextInfo.group.Single(x => x.GroupId == GroupId);
            

            return View("Edit", group);
        }

        [HttpPost]
        public IActionResult Edit(GroupInfo changedGroup)
        {
            contextInfo.Update(changedGroup);
            contextInfo.SaveChanges();

            return RedirectToAction("Appointments");
        }

        [HttpGet]
        public IActionResult Delete(int GroupId)
        {

            var group = contextInfo.group.Single(x => x.GroupId == GroupId);


            return View(group);
        }

        [HttpPost]
        public IActionResult Delete(GroupInfo groupDeleted)
        { 
            contextInfo.group.Remove(groupDeleted);
            contextInfo.SaveChanges();


            List<Appointment> results = contextInfo.appointments.Where(a => a.AppointmentID == groupDeleted.AppointmentID).ToList();
            foreach (Appointment app in results)
            {
                app.Taken = false;
            }
            contextInfo.SaveChanges();

            return RedirectToAction("Appointments");
        }



    }
}

