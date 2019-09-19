using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterProject.Api.Migrations
{
    public partial class Update_connectionString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 192, 173, 58, 180, 55, 219, 47, 4, 129, 142, 249, 91, 21, 226, 152, 185, 150, 200, 24, 74 }, new byte[] { 53, 235, 65, 194, 85, 207, 110, 96, 142, 132, 89, 163, 48, 214, 176, 130 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 197, 57, 9, 43, 234, 252, 167, 83, 128, 87, 50, 1, 231, 154, 73, 127, 159, 145, 52, 105 }, new byte[] { 41, 2, 199, 149, 164, 85, 127, 171, 118, 5, 160, 167, 99, 146, 106, 134 } });
        }
    }
}
