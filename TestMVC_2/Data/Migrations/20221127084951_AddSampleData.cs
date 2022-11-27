using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestMVC_2.Data.Migrations
{
    public partial class AddSampleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "Name", "Position" },
                values: new object[] { new Guid("398d10fe-4b8d-4606-8e9c-bd2c78d4e001"), 29, "Anna Simmons", "Software Developer" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "Name", "Position" },
                values: new object[] { new Guid("e310a6cb-6677-4aa6-93c7-2763956f7a97"), 26, "Mark Miens", "Software Developer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("398d10fe-4b8d-4606-8e9c-bd2c78d4e001"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("e310a6cb-6677-4aa6-93c7-2763956f7a97"));
        }
    }
}
