﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Misison12GroupProject.Models;

namespace Misison12GroupProject.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220321162440_ModelUpdate")]
    partial class ModelUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Misison12GroupProject.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Day")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Taken")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Time")
                        .HasColumnType("TEXT");

                    b.HasKey("AppointmentID");

                    b.ToTable("appointments");

                    b.HasData(
                        new
                        {
                            AppointmentID = 1,
                            Day = "Monday",
                            Taken = false,
                            Time = "8:00 AM"
                        },
                        new
                        {
                            AppointmentID = 2,
                            Day = "Monday",
                            Taken = false,
                            Time = "9:00 AM"
                        },
                        new
                        {
                            AppointmentID = 3,
                            Day = "Monday",
                            Taken = false,
                            Time = "10:00 AM"
                        },
                        new
                        {
                            AppointmentID = 4,
                            Day = "Monday",
                            Taken = false,
                            Time = "11:00 AM"
                        },
                        new
                        {
                            AppointmentID = 5,
                            Day = "Monday",
                            Taken = false,
                            Time = "12:00 PM"
                        },
                        new
                        {
                            AppointmentID = 6,
                            Day = "Monday",
                            Taken = false,
                            Time = "1:00 PM"
                        },
                        new
                        {
                            AppointmentID = 7,
                            Day = "Monday",
                            Taken = false,
                            Time = "2:00 PM"
                        },
                        new
                        {
                            AppointmentID = 8,
                            Day = "Monday",
                            Taken = false,
                            Time = "3:00 PM"
                        },
                        new
                        {
                            AppointmentID = 9,
                            Day = "Monday",
                            Taken = false,
                            Time = "4:00 PM"
                        },
                        new
                        {
                            AppointmentID = 10,
                            Day = "Monday",
                            Taken = false,
                            Time = "5:00 PM"
                        },
                        new
                        {
                            AppointmentID = 11,
                            Day = "Monday",
                            Taken = false,
                            Time = "6:00 PM"
                        },
                        new
                        {
                            AppointmentID = 12,
                            Day = "Monday",
                            Taken = false,
                            Time = "7:00 PM"
                        },
                        new
                        {
                            AppointmentID = 13,
                            Day = "Monday",
                            Taken = false,
                            Time = "8:00 PM"
                        },
                        new
                        {
                            AppointmentID = 14,
                            Day = "Tuesday",
                            Taken = false,
                            Time = "8:00 AM"
                        },
                        new
                        {
                            AppointmentID = 15,
                            Day = "Tuesday",
                            Taken = false,
                            Time = "9:00 AM"
                        },
                        new
                        {
                            AppointmentID = 16,
                            Day = "Tuesday",
                            Taken = false,
                            Time = "10:00 AM"
                        },
                        new
                        {
                            AppointmentID = 17,
                            Day = "Tuesday",
                            Taken = false,
                            Time = "11:00 AM"
                        },
                        new
                        {
                            AppointmentID = 18,
                            Day = "Tuesday",
                            Taken = false,
                            Time = "12:00 PM"
                        },
                        new
                        {
                            AppointmentID = 19,
                            Day = "Tuesday",
                            Taken = false,
                            Time = "1:00 PM"
                        },
                        new
                        {
                            AppointmentID = 20,
                            Day = "Tuesday",
                            Taken = false,
                            Time = "2:00 PM"
                        },
                        new
                        {
                            AppointmentID = 21,
                            Day = "Tuesday",
                            Taken = false,
                            Time = "3:00 PM"
                        },
                        new
                        {
                            AppointmentID = 22,
                            Day = "Tuesday",
                            Taken = false,
                            Time = "4:00 PM"
                        },
                        new
                        {
                            AppointmentID = 23,
                            Day = "Tuesday",
                            Taken = false,
                            Time = "5:00 PM"
                        },
                        new
                        {
                            AppointmentID = 24,
                            Day = "Tuesday",
                            Taken = false,
                            Time = "6:00 PM"
                        },
                        new
                        {
                            AppointmentID = 25,
                            Day = "Tuesday",
                            Taken = false,
                            Time = "7:00 PM"
                        },
                        new
                        {
                            AppointmentID = 26,
                            Day = "Tuesday",
                            Taken = false,
                            Time = "8:00 PM"
                        },
                        new
                        {
                            AppointmentID = 27,
                            Day = "Wednesday",
                            Taken = false,
                            Time = "8:00 AM"
                        },
                        new
                        {
                            AppointmentID = 28,
                            Day = "Wednesday",
                            Taken = false,
                            Time = "9:00 AM"
                        },
                        new
                        {
                            AppointmentID = 29,
                            Day = "Wednesday",
                            Taken = false,
                            Time = "10:00 AM"
                        },
                        new
                        {
                            AppointmentID = 30,
                            Day = "Wednesday",
                            Taken = false,
                            Time = "11:00 AM"
                        },
                        new
                        {
                            AppointmentID = 31,
                            Day = "Wednesday",
                            Taken = false,
                            Time = "12:00 PM"
                        },
                        new
                        {
                            AppointmentID = 32,
                            Day = "Wednesday",
                            Taken = false,
                            Time = "1:00 PM"
                        },
                        new
                        {
                            AppointmentID = 33,
                            Day = "Wednesday",
                            Taken = false,
                            Time = "2:00 PM"
                        },
                        new
                        {
                            AppointmentID = 34,
                            Day = "Wednesday",
                            Taken = false,
                            Time = "3:00 PM"
                        },
                        new
                        {
                            AppointmentID = 35,
                            Day = "Wednesday",
                            Taken = false,
                            Time = "4:00 PM"
                        },
                        new
                        {
                            AppointmentID = 36,
                            Day = "Wednesday",
                            Taken = false,
                            Time = "5:00 PM"
                        },
                        new
                        {
                            AppointmentID = 37,
                            Day = "Wednesday",
                            Taken = false,
                            Time = "6:00 PM"
                        },
                        new
                        {
                            AppointmentID = 38,
                            Day = "Wednesday",
                            Taken = false,
                            Time = "7:00 PM"
                        },
                        new
                        {
                            AppointmentID = 39,
                            Day = "Wednesday",
                            Taken = false,
                            Time = "8:00 PM"
                        },
                        new
                        {
                            AppointmentID = 40,
                            Day = "Thursday",
                            Taken = false,
                            Time = "8:00 AM"
                        },
                        new
                        {
                            AppointmentID = 41,
                            Day = "Thursday",
                            Taken = false,
                            Time = "9:00 AM"
                        },
                        new
                        {
                            AppointmentID = 42,
                            Day = "Thursday",
                            Taken = false,
                            Time = "10:00 AM"
                        },
                        new
                        {
                            AppointmentID = 43,
                            Day = "Thursday",
                            Taken = false,
                            Time = "11:00 AM"
                        },
                        new
                        {
                            AppointmentID = 44,
                            Day = "Thursday",
                            Taken = false,
                            Time = "12:00 PM"
                        },
                        new
                        {
                            AppointmentID = 45,
                            Day = "Thursday",
                            Taken = false,
                            Time = "1:00 PM"
                        },
                        new
                        {
                            AppointmentID = 46,
                            Day = "Thursday",
                            Taken = false,
                            Time = "2:00 PM"
                        },
                        new
                        {
                            AppointmentID = 47,
                            Day = "Thursday",
                            Taken = false,
                            Time = "3:00 PM"
                        },
                        new
                        {
                            AppointmentID = 48,
                            Day = "Thursday",
                            Taken = false,
                            Time = "4:00 PM"
                        },
                        new
                        {
                            AppointmentID = 49,
                            Day = "Thursday",
                            Taken = false,
                            Time = "5:00 PM"
                        },
                        new
                        {
                            AppointmentID = 50,
                            Day = "Thursday",
                            Taken = false,
                            Time = "6:00 PM"
                        },
                        new
                        {
                            AppointmentID = 51,
                            Day = "Thursday",
                            Taken = false,
                            Time = "7:00 PM"
                        },
                        new
                        {
                            AppointmentID = 52,
                            Day = "Thursday",
                            Taken = false,
                            Time = "8:00 PM"
                        },
                        new
                        {
                            AppointmentID = 53,
                            Day = "Friday",
                            Taken = false,
                            Time = "8:00 AM"
                        },
                        new
                        {
                            AppointmentID = 54,
                            Day = "Friday",
                            Taken = false,
                            Time = "9:00 AM"
                        },
                        new
                        {
                            AppointmentID = 55,
                            Day = "Friday",
                            Taken = false,
                            Time = "10:00 AM"
                        },
                        new
                        {
                            AppointmentID = 56,
                            Day = "Friday",
                            Taken = false,
                            Time = "11:00 AM"
                        },
                        new
                        {
                            AppointmentID = 57,
                            Day = "Friday",
                            Taken = false,
                            Time = "12:00 PM"
                        },
                        new
                        {
                            AppointmentID = 58,
                            Day = "Friday",
                            Taken = false,
                            Time = "1:00 PM"
                        },
                        new
                        {
                            AppointmentID = 59,
                            Day = "Friday",
                            Taken = false,
                            Time = "2:00 PM"
                        },
                        new
                        {
                            AppointmentID = 60,
                            Day = "Friday",
                            Taken = false,
                            Time = "3:00 PM"
                        },
                        new
                        {
                            AppointmentID = 61,
                            Day = "Friday",
                            Taken = false,
                            Time = "4:00 PM"
                        },
                        new
                        {
                            AppointmentID = 62,
                            Day = "Friday",
                            Taken = false,
                            Time = "5:00 PM"
                        },
                        new
                        {
                            AppointmentID = 63,
                            Day = "Friday",
                            Taken = false,
                            Time = "6:00 PM"
                        },
                        new
                        {
                            AppointmentID = 64,
                            Day = "Friday",
                            Taken = false,
                            Time = "7:00 PM"
                        },
                        new
                        {
                            AppointmentID = 65,
                            Day = "Friday",
                            Taken = false,
                            Time = "8:00 PM"
                        },
                        new
                        {
                            AppointmentID = 66,
                            Day = "Saturday",
                            Taken = false,
                            Time = "8:00 AM"
                        },
                        new
                        {
                            AppointmentID = 67,
                            Day = "Saturday",
                            Taken = false,
                            Time = "9:00 AM"
                        },
                        new
                        {
                            AppointmentID = 68,
                            Day = "Saturday",
                            Taken = false,
                            Time = "10:00 AM"
                        },
                        new
                        {
                            AppointmentID = 69,
                            Day = "Saturday",
                            Taken = false,
                            Time = "11:00 AM"
                        },
                        new
                        {
                            AppointmentID = 70,
                            Day = "Saturday",
                            Taken = false,
                            Time = "12:00 PM"
                        },
                        new
                        {
                            AppointmentID = 71,
                            Day = "Saturday",
                            Taken = false,
                            Time = "1:00 PM"
                        },
                        new
                        {
                            AppointmentID = 72,
                            Day = "Saturday",
                            Taken = false,
                            Time = "2:00 PM"
                        },
                        new
                        {
                            AppointmentID = 73,
                            Day = "Saturday",
                            Taken = false,
                            Time = "3:00 PM"
                        },
                        new
                        {
                            AppointmentID = 74,
                            Day = "Saturday",
                            Taken = false,
                            Time = "4:00 PM"
                        },
                        new
                        {
                            AppointmentID = 75,
                            Day = "Saturday",
                            Taken = false,
                            Time = "5:00 PM"
                        },
                        new
                        {
                            AppointmentID = 76,
                            Day = "Saturday",
                            Taken = false,
                            Time = "6:00 PM"
                        },
                        new
                        {
                            AppointmentID = 77,
                            Day = "Saturday",
                            Taken = false,
                            Time = "7:00 PM"
                        },
                        new
                        {
                            AppointmentID = 78,
                            Day = "Saturday",
                            Taken = false,
                            Time = "8:00 PM"
                        },
                        new
                        {
                            AppointmentID = 79,
                            Day = "Sunday",
                            Taken = false,
                            Time = "8:00 AM"
                        },
                        new
                        {
                            AppointmentID = 80,
                            Day = "Sunday",
                            Taken = false,
                            Time = "9:00 AM"
                        },
                        new
                        {
                            AppointmentID = 81,
                            Day = "Sunday",
                            Taken = false,
                            Time = "10:00 AM"
                        },
                        new
                        {
                            AppointmentID = 82,
                            Day = "Sunday",
                            Taken = false,
                            Time = "11:00 AM"
                        },
                        new
                        {
                            AppointmentID = 83,
                            Day = "Sunday",
                            Taken = false,
                            Time = "12:00 PM"
                        },
                        new
                        {
                            AppointmentID = 84,
                            Day = "Sunday",
                            Taken = false,
                            Time = "1:00 PM"
                        },
                        new
                        {
                            AppointmentID = 85,
                            Day = "Sunday",
                            Taken = false,
                            Time = "2:00 PM"
                        },
                        new
                        {
                            AppointmentID = 86,
                            Day = "Sunday",
                            Taken = false,
                            Time = "3:00 PM"
                        },
                        new
                        {
                            AppointmentID = 87,
                            Day = "Sunday",
                            Taken = false,
                            Time = "4:00 PM"
                        },
                        new
                        {
                            AppointmentID = 88,
                            Day = "Sunday",
                            Taken = false,
                            Time = "5:00 PM"
                        },
                        new
                        {
                            AppointmentID = 89,
                            Day = "Sunday",
                            Taken = false,
                            Time = "6:00 PM"
                        },
                        new
                        {
                            AppointmentID = 90,
                            Day = "Sunday",
                            Taken = false,
                            Time = "7:00 PM"
                        },
                        new
                        {
                            AppointmentID = 91,
                            Day = "Sunday",
                            Taken = false,
                            Time = "8:00 PM"
                        });
                });

            modelBuilder.Entity("Misison12GroupProject.Models.GroupInfo", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AppointmentID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("GroupName")
                        .HasColumnType("TEXT");

                    b.Property<int>("GroupSize")
                        .HasColumnType("INTEGER");

                    b.Property<string>("email")
                        .HasColumnType("TEXT");

                    b.Property<string>("phone")
                        .HasColumnType("TEXT");

                    b.HasKey("GroupId");

                    b.HasIndex("AppointmentID");

                    b.ToTable("group");

                    b.HasData(
                        new
                        {
                            GroupId = 1,
                            AppointmentID = 1,
                            GroupName = "Group 10",
                            GroupSize = 4,
                            email = "dmitchellbuhler@gmail.com",
                            phone = "425-698-3436"
                        });
                });

            modelBuilder.Entity("Misison12GroupProject.Models.GroupInfo", b =>
                {
                    b.HasOne("Misison12GroupProject.Models.Appointment", "Appointment")
                        .WithMany()
                        .HasForeignKey("AppointmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
