using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterProject.Api.Migrations
{
    public partial class EDITUserStartYearNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "StartYear",
                table: "Users",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 20, 134, 9, 197, 9, 18, 187, 237, 31, 22, 228, 105, 84, 71, 150, 67, 240, 35, 179, 20 }, new byte[] { 172, 5, 72, 188, 162, 240, 203, 31, 153, 83, 30, 72, 172, 150, 86, 48 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "StartYear",
                table: "Users",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 123, 110, 178, 183, 151, 220, 213, 25, 78, 73, 197, 84, 176, 65, 127, 222, 231, 39, 74, 82 }, new byte[] { 37, 114, 117, 129, 194, 238, 252, 23, 79, 232, 84, 156, 184, 147, 196, 152 } });
        }
    }
}
