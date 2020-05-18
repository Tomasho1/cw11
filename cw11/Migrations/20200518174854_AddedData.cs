using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cw11.Migrations
{
    public partial class AddedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doktor",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "mkowalski@gmail.com", "Maciej", "Kowalski" },
                    { 2, "romanpolak@gmail.com", "Roman", "Polak" }
                });

            migrationBuilder.InsertData(
                table: "Lek",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Na przeziębienie", "Rutinoscorbin", "Tabletki" },
                    { 2, "Na kaszel", "Herbapect", "Syrop" }
                });

            migrationBuilder.InsertData(
                table: "Pacjent",
                columns: new[] { "IdPatient", "Birthday", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1992, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adam", "Wesołowski" },
                    { 2, new DateTime(1981, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tomasz", "Mazur" }
                });

            migrationBuilder.InsertData(
                table: "Recepta",
                columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 18, 19, 48, 54, 264, DateTimeKind.Local).AddTicks(2745), new DateTime(2020, 6, 18, 19, 48, 54, 266, DateTimeKind.Local).AddTicks(6084), 1, 1 },
                    { 2, new DateTime(2020, 5, 18, 19, 48, 54, 266, DateTimeKind.Local).AddTicks(7535), new DateTime(2020, 6, 18, 19, 48, 54, 266, DateTimeKind.Local).AddTicks(7554), 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Recepta_Lek",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[,]
                {
                    { 1, 1, "Brak", 2 },
                    { 2, 2, "Przed posiłkiem", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doktor",
                keyColumn: "IdDoctor",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doktor",
                keyColumn: "IdDoctor",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lek",
                keyColumn: "IdMedicament",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lek",
                keyColumn: "IdMedicament",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pacjent",
                keyColumn: "IdPatient",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pacjent",
                keyColumn: "IdPatient",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recepta",
                keyColumn: "IdPrescription",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recepta",
                keyColumn: "IdPrescription",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recepta_Lek",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Recepta_Lek",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 2, 2 });
        }
    }
}
