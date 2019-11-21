using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterProject.Api.Migrations
{
    public partial class Update_User_GPAnullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "GPA",
                table: "Users",
                nullable: true,
                oldClrType: typeof(float));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "GPA", "PasswordHash", "PasswordSalt" },
                values: new object[] { null, new byte[] { 230, 49, 232, 63, 92, 52, 174, 88, 191, 240, 127, 180, 86, 149, 201, 1, 44, 21, 9, 56 }, new byte[] { 130, 140, 95, 163, 65, 80, 43, 81, 49, 40, 81, 54, 96, 111, 150, 27 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "GPA",
                table: "Users",
                nullable: false,
                oldClrType: typeof(float),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "GPA", "PasswordHash", "PasswordSalt" },
                values: new object[] { 0f, new byte[] { 20, 134, 9, 197, 9, 18, 187, 237, 31, 22, 228, 105, 84, 71, 150, 67, 240, 35, 179, 20 }, new byte[] { 172, 5, 72, 188, 162, 240, 203, 31, 153, 83, 30, 72, 172, 150, 86, 48 } });
        }
    }
}
