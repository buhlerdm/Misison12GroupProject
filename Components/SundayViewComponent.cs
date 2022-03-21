using Microsoft.AspNetCore.Mvc;
using Misison12GroupProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Misison12GroupProject.Components
{
    public class SundayViewComponent : ViewComponent
    {
       
            private ApplicationContext contextInfo { get; set; }

            public SundayViewComponent(ApplicationContext temp)
            {
                contextInfo = temp;
            }


            public IViewComponentResult Invoke()
            {
                var sundayAppointment = contextInfo.appointments
                    .Where(a => a.Taken == false)
                    .Where( a => a.Day == "Sunday")
                    .OrderBy(a => a.AppointmentID);


                return View(sundayAppointment);
            }
    }
}


