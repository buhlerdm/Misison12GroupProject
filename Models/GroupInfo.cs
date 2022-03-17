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

        public string GroupName { get; set; }

        [Range(1, 15, ErrorMessage = "Group must have between 1 and 15 guests")]
        public int GroupSize { get; set; }

        public string email { get; set; }

        public string phone { get; set; }

        // Foreign Key
        public int AppointmentID { get; set; }
        public Appointment Appointment { get; set; }
    }
}
