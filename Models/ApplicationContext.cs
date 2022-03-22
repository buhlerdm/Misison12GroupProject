using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Misison12GroupProject.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<Appointment> appointments { get; set; }
        public DbSet<GroupInfo> group { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Appointment>().HasData(
                    new Appointment { AppointmentID = 1, Day= "Monday", Taken= false, Time="8:00 AM" },
                    new Appointment { AppointmentID = 2, Day = "Monday", Taken = false, Time = "9:00 AM" },
                    new Appointment { AppointmentID = 3, Day = "Monday", Taken = false, Time = "10:00 AM" },
                    new Appointment { AppointmentID = 4, Day = "Monday", Taken = false, Time = "11:00 AM" },
                    new Appointment { AppointmentID = 5, Day = "Monday", Taken = false, Time = "12:00 PM" },
                    new Appointment { AppointmentID = 6, Day = "Monday", Taken = false, Time = "1:00 PM" },
                    new Appointment { AppointmentID = 7, Day = "Monday", Taken = false, Time = "2:00 PM" },
                    new Appointment { AppointmentID = 8, Day = "Monday", Taken = false, Time = "3:00 PM" },
                    new Appointment { AppointmentID = 9, Day = "Monday", Taken = false, Time = "4:00 PM" },
                    new Appointment { AppointmentID = 10, Day = "Monday", Taken = false, Time = "5:00 PM" },
                    new Appointment { AppointmentID = 11, Day = "Monday", Taken = false, Time = "6:00 PM" },
                    new Appointment { AppointmentID = 12, Day = "Monday", Taken = false, Time = "7:00 PM" },
                    new Appointment { AppointmentID = 13, Day = "Monday", Taken = false, Time = "8:00 PM" },

                    new Appointment { AppointmentID = 14, Day = "Tuesday", Taken = false, Time = "8:00 AM" },
                    new Appointment { AppointmentID = 15, Day = "Tuesday", Taken = false, Time = "9:00 AM" },
                    new Appointment { AppointmentID = 16, Day = "Tuesday", Taken = false, Time = "10:00 AM" },
                    new Appointment { AppointmentID = 17, Day = "Tuesday", Taken = false, Time = "11:00 AM" },
                    new Appointment { AppointmentID = 18, Day = "Tuesday", Taken = false, Time = "12:00 PM" },
                    new Appointment { AppointmentID = 19, Day = "Tuesday", Taken = false, Time = "1:00 PM" },
                    new Appointment { AppointmentID = 20, Day = "Tuesday", Taken = false, Time = "2:00 PM" },
                    new Appointment { AppointmentID = 21, Day = "Tuesday", Taken = false, Time = "3:00 PM" },
                    new Appointment { AppointmentID = 22, Day = "Tuesday", Taken = false, Time = "4:00 PM" },
                    new Appointment { AppointmentID = 23, Day = "Tuesday", Taken = false, Time = "5:00 PM" },
                    new Appointment { AppointmentID = 24, Day = "Tuesday", Taken = false, Time = "6:00 PM" },
                    new Appointment { AppointmentID = 25, Day = "Tuesday", Taken = false, Time = "7:00 PM" },
                    new Appointment { AppointmentID = 26, Day = "Tuesday", Taken = false, Time = "8:00 PM" },

                    new Appointment { AppointmentID = 27, Day = "Wednesday", Taken = false, Time = "8:00 AM" },
                    new Appointment { AppointmentID = 28, Day = "Wednesday", Taken = false, Time = "9:00 AM" },
                    new Appointment { AppointmentID = 29, Day = "Wednesday", Taken = false, Time = "10:00 AM" },
                    new Appointment { AppointmentID = 30, Day = "Wednesday", Taken = false, Time = "11:00 AM" },
                    new Appointment { AppointmentID = 31, Day = "Wednesday", Taken = false, Time = "12:00 PM" },
                    new Appointment { AppointmentID = 32, Day = "Wednesday", Taken = false, Time = "1:00 PM" },
                    new Appointment { AppointmentID = 33, Day = "Wednesday", Taken = false, Time = "2:00 PM" },
                    new Appointment { AppointmentID = 34, Day = "Wednesday", Taken = false, Time = "3:00 PM" },
                    new Appointment { AppointmentID = 35, Day = "Wednesday", Taken = false, Time = "4:00 PM" },
                    new Appointment { AppointmentID = 36, Day = "Wednesday", Taken = false, Time = "5:00 PM" },
                    new Appointment { AppointmentID = 37, Day = "Wednesday", Taken = false, Time = "6:00 PM" },
                    new Appointment { AppointmentID = 38, Day = "Wednesday", Taken = false, Time = "7:00 PM" },
                    new Appointment { AppointmentID = 39, Day = "Wednesday", Taken = false, Time = "8:00 PM" },

                    new Appointment { AppointmentID = 40, Day = "Thursday", Taken = false, Time = "8:00 AM" },
                    new Appointment { AppointmentID = 41, Day = "Thursday", Taken = false, Time = "9:00 AM" },
                    new Appointment { AppointmentID = 42, Day = "Thursday", Taken = false, Time = "10:00 AM" },
                    new Appointment { AppointmentID = 43, Day = "Thursday", Taken = false, Time = "11:00 AM" },
                    new Appointment { AppointmentID = 44, Day = "Thursday", Taken = false, Time = "12:00 PM" },
                    new Appointment { AppointmentID = 45, Day = "Thursday", Taken = false, Time = "1:00 PM" },
                    new Appointment { AppointmentID = 46, Day = "Thursday", Taken = false, Time = "2:00 PM" },
                    new Appointment { AppointmentID = 47, Day = "Thursday", Taken = false, Time = "3:00 PM" },
                    new Appointment { AppointmentID = 48, Day = "Thursday", Taken = false, Time = "4:00 PM" },
                    new Appointment { AppointmentID = 49, Day = "Thursday", Taken = false, Time = "5:00 PM" },
                    new Appointment { AppointmentID = 50, Day = "Thursday", Taken = false, Time = "6:00 PM" },
                    new Appointment { AppointmentID = 51, Day = "Thursday", Taken = false, Time = "7:00 PM" },
                    new Appointment { AppointmentID = 52, Day = "Thursday", Taken = false, Time = "8:00 PM" },

                    new Appointment { AppointmentID = 53, Day = "Friday", Taken = false, Time = "8:00 AM" },
                    new Appointment { AppointmentID = 54, Day = "Friday", Taken = false, Time = "9:00 AM" },
                    new Appointment { AppointmentID = 55, Day = "Friday", Taken = false, Time = "10:00 AM" },
                    new Appointment { AppointmentID = 56, Day = "Friday", Taken = false, Time = "11:00 AM" },
                    new Appointment { AppointmentID = 57, Day = "Friday", Taken = false, Time = "12:00 PM" },
                    new Appointment { AppointmentID = 58, Day = "Friday", Taken = false, Time = "1:00 PM" },
                    new Appointment { AppointmentID = 59, Day = "Friday", Taken = false, Time = "2:00 PM" },
                    new Appointment { AppointmentID = 60, Day = "Friday", Taken = false, Time = "3:00 PM" },
                    new Appointment { AppointmentID = 61, Day = "Friday", Taken = false, Time = "4:00 PM" },
                    new Appointment { AppointmentID = 62, Day = "Friday", Taken = false, Time = "5:00 PM" },
                    new Appointment { AppointmentID = 63, Day = "Friday", Taken = false, Time = "6:00 PM" },
                    new Appointment { AppointmentID = 64, Day = "Friday", Taken = false, Time = "7:00 PM" },
                    new Appointment { AppointmentID = 65, Day = "Friday", Taken = false, Time = "8:00 PM" },

                    new Appointment { AppointmentID = 66, Day = "Saturday", Taken = false, Time = "8:00 AM" },
                    new Appointment { AppointmentID = 67, Day = "Saturday", Taken = false, Time = "9:00 AM" },
                    new Appointment { AppointmentID = 68, Day = "Saturday", Taken = false, Time = "10:00 AM" },
                    new Appointment { AppointmentID = 69, Day = "Saturday", Taken = false, Time = "11:00 AM" },
                    new Appointment { AppointmentID = 70, Day = "Saturday", Taken = false, Time = "12:00 PM" },
                    new Appointment { AppointmentID = 71, Day = "Saturday", Taken = false, Time = "1:00 PM" },
                    new Appointment { AppointmentID = 72, Day = "Saturday", Taken = false, Time = "2:00 PM" },
                    new Appointment { AppointmentID = 73, Day = "Saturday", Taken = false, Time = "3:00 PM" },
                    new Appointment { AppointmentID = 74, Day = "Saturday", Taken = false, Time = "4:00 PM" },
                    new Appointment { AppointmentID = 75, Day = "Saturday", Taken = false, Time = "5:00 PM" },
                    new Appointment { AppointmentID = 76, Day = "Saturday", Taken = false, Time = "6:00 PM" },
                    new Appointment { AppointmentID = 77, Day = "Saturday", Taken = false, Time = "7:00 PM" },
                    new Appointment { AppointmentID = 78, Day = "Saturday", Taken = false, Time = "8:00 PM" },

                    new Appointment { AppointmentID = 79, Day = "Sunday", Taken = false, Time = "8:00 AM" },
                    new Appointment { AppointmentID = 80, Day = "Sunday", Taken = false, Time = "9:00 AM" },
                    new Appointment { AppointmentID = 81, Day = "Sunday", Taken = false, Time = "10:00 AM" },
                    new Appointment { AppointmentID = 82, Day = "Sunday", Taken = false, Time = "11:00 AM" },
                    new Appointment { AppointmentID = 83, Day = "Sunday", Taken = false, Time = "12:00 PM" },
                    new Appointment { AppointmentID = 84, Day = "Sunday", Taken = false, Time = "1:00 PM" },
                    new Appointment { AppointmentID = 85, Day = "Sunday", Taken = false, Time = "2:00 PM" },
                    new Appointment { AppointmentID = 86, Day = "Sunday", Taken = false, Time = "3:00 PM" },
                    new Appointment { AppointmentID = 87, Day = "Sunday", Taken = false, Time = "4:00 PM" },
                    new Appointment { AppointmentID = 88, Day = "Sunday", Taken = false, Time = "5:00 PM" },
                    new Appointment { AppointmentID = 89, Day = "Sunday", Taken = false, Time = "6:00 PM" },
                    new Appointment { AppointmentID = 90, Day = "Sunday", Taken = false, Time = "7:00 PM" },
                    new Appointment { AppointmentID = 91, Day = "Sunday", Taken = false, Time = "8:00 PM" }
                );


            mb.Entity<GroupInfo>().HasData(
                    new GroupInfo
                    {
                        GroupId = 1,
                        GroupName = "Group 10",
                        GroupSize = 4,
                        email = "dmitchellbuhler@gmail.com",
                        phone = "425-698-3436",
                        AppointmentID = 1
                    }

                );
        }
    }
}
