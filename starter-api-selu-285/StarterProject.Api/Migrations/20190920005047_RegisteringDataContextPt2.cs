using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterProject.Api.Migrations
{
    public partial class RegisteringDataContextPt2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 255, 24, 25, 46, 213, 167, 76, 96, 242, 82, 21, 226, 19, 5, 229, 135, 213, 10, 200, 189 }, new byte[] { 68, 109, 235, 201, 212, 123, 41, 56, 238, 82, 112, 29, 175, 64, 132, 26 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 193, 41, 230, 209, 207, 133, 68, 35, 44, 238, 247, 161, 119, 57, 162, 155, 100, 23, 220, 230 }, new byte[] { 82, 206, 12, 140, 142, 176, 152, 110, 1, 142, 158, 14, 197, 47, 222, 66 } });
        }
    }
}
