using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterProject.Api.Migrations
{
    public partial class Update_MajorTable_MajorNameSpellingFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MajornName",
                table: "Majors",
                newName: "MajorName");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 226, 249, 77, 230, 200, 77, 120, 205, 228, 247, 92, 112, 175, 161, 61, 154, 59, 109, 68, 95 }, new byte[] { 49, 75, 185, 161, 178, 231, 223, 50, 211, 84, 43, 246, 54, 209, 115, 217 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MajorName",
                table: "Majors",
                newName: "MajornName");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 108, 64, 180, 106, 134, 131, 51, 116, 25, 65, 87, 109, 86, 251, 228, 17, 174, 88, 201, 132 }, new byte[] { 40, 148, 89, 112, 27, 189, 149, 25, 223, 105, 200, 2, 137, 71, 212, 41 } });
        }
    }
}
