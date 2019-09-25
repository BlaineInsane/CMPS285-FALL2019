using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterProject.Api.Migrations
{
    public partial class Update_UserTable_AddGpaColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "GPA",
                table: "Users",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 0, 134, 155, 204, 60, 163, 192, 103, 187, 33, 188, 6, 237, 25, 96, 113, 12, 157, 184, 190 }, new byte[] { 77, 20, 75, 188, 204, 204, 189, 87, 160, 189, 71, 161, 6, 131, 189, 56 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GPA",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 255, 24, 25, 46, 213, 167, 76, 96, 242, 82, 21, 226, 19, 5, 229, 135, 213, 10, 200, 189 }, new byte[] { 68, 109, 235, 201, 212, 123, 41, 56, 238, 82, 112, 29, 175, 64, 132, 26 } });
        }
    }
}
