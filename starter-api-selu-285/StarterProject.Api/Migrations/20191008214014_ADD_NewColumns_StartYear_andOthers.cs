using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterProject.Api.Migrations
{
    public partial class ADD_NewColumns_StartYear_andOthers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StartYear",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt", "StartYear" },
                values: new object[] { new byte[] { 72, 183, 208, 26, 71, 231, 94, 231, 239, 4, 41, 13, 144, 133, 9, 144, 178, 8, 125, 177 }, new byte[] { 84, 164, 221, 81, 220, 228, 182, 188, 203, 215, 213, 21, 20, 35, 17, 145 }, 2017 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StartYear",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 226, 249, 77, 230, 200, 77, 120, 205, 228, 247, 92, 112, 175, 161, 61, 154, 59, 109, 68, 95 }, new byte[] { 49, 75, 185, 161, 178, 231, 223, 50, 211, 84, 43, 246, 54, 209, 115, 217 } });
        }
    }
}
