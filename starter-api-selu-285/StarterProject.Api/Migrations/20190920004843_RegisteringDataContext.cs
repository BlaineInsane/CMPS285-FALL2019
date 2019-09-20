using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterProject.Api.Migrations
{
    public partial class RegisteringDataContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 193, 41, 230, 209, 207, 133, 68, 35, 44, 238, 247, 161, 119, 57, 162, 155, 100, 23, 220, 230 }, new byte[] { 82, 206, 12, 140, 142, 176, 152, 110, 1, 142, 158, 14, 197, 47, 222, 66 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 75, 17, 111, 11, 95, 102, 220, 35, 129, 238, 128, 87, 5, 70, 216, 64, 103, 44, 216, 173 }, new byte[] { 36, 144, 75, 66, 140, 150, 73, 186, 168, 239, 41, 141, 181, 2, 5, 99 } });
        }
    }
}
