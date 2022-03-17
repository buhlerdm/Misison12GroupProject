using Microsoft.EntityFrameworkCore.Migrations;

namespace Misison12GroupProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "appointments",
                columns: table => new
                {
                    AppointmentID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Time = table.Column<string>(nullable: true),
                    Taken = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appointments", x => x.AppointmentID);
                });

            migrationBuilder.CreateTable(
                name: "group",
                columns: table => new
                {
                    GroupId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(nullable: true),
                    GroupSize = table.Column<int>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    AppointmentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_group", x => x.GroupId);
                    table.ForeignKey(
                        name: "FK_group_appointments_AppointmentID",
                        column: x => x.AppointmentID,
                        principalTable: "appointments",
                        principalColumn: "AppointmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 1, false, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 66, false, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 65, false, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 64, false, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 63, false, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 62, false, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 61, false, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 60, false, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 59, false, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 58, false, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 57, false, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 56, false, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 55, false, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 54, false, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 53, false, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 52, false, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 51, false, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 50, false, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 49, false, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 48, false, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 67, false, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 47, false, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 68, false, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 70, false, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 89, false, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 88, false, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 87, false, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 86, false, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 85, false, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 84, false, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 83, false, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 82, false, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 81, false, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 80, false, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 79, false, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 78, false, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 77, false, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 76, false, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 75, false, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 74, false, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 73, false, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 72, false, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 71, false, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 69, false, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 90, false, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 46, false, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 44, false, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 20, false, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 19, false, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 18, false, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 17, false, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 16, false, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 15, false, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 14, false, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 13, false, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 12, false, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 11, false, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 10, false, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 9, false, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 8, false, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 7, false, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 6, false, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 5, false, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 4, false, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 3, false, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 2, false, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 21, false, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 45, false, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 22, false, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 24, false, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 43, false, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 42, false, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 41, false, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 40, false, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 39, false, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 38, false, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 37, false, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 36, false, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 35, false, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 34, false, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 33, false, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 32, false, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 31, false, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 30, false, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 29, false, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 28, false, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 27, false, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 26, false, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 25, false, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 23, false, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentID", "Taken", "Time" },
                values: new object[] { 91, false, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "group",
                columns: new[] { "GroupId", "AppointmentID", "GroupName", "GroupSize", "email", "phone" },
                values: new object[] { 1, 1, "Group 10", 4, "dmitchellbuhler@gmail.com", "425-698-3436" });

            migrationBuilder.CreateIndex(
                name: "IX_group_AppointmentID",
                table: "group",
                column: "AppointmentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "group");

            migrationBuilder.DropTable(
                name: "appointments");
        }
    }
}
