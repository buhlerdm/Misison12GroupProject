using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Misison12GroupProject.Models
{
    public class Appointment
    {
        [Key]
        [Required]
        public int AppointmentID { get; set; }

        public string Day { get; set; }

        public string Time { get; set; }

        public bool Taken { get; set; }

    }
}
