using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Misison12GroupProject.Models
{
    public class GroupInfo
    {
        [Key]
        [Required]
        public int GroupId { get; set; }

        [Required(ErrorMessage = "Appointment must have a group name")]
        public string GroupName { get; set; }

        [Required]
        [Range(1, 15, ErrorMessage = "Group must have between 1 and 15 guests")]
        public int GroupSize { get; set; }

        [Required(ErrorMessage = "Appointment must have an email")]
        public string email { get; set; }

        [Required(ErrorMessage = "Appointment must have a phone number")]
        public string phone { get; set; }

        // Foreign Key
        public int AppointmentID { get; set; }
        public Appointment Appointment { get; set; }
    }
}
