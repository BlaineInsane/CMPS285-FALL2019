using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterProject.Api.Migrations
{
    public partial class pwchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 123, 110, 178, 183, 151, 220, 213, 25, 78, 73, 197, 84, 176, 65, 127, 222, 231, 39, 74, 82 }, new byte[] { 37, 114, 117, 129, 194, 238, 252, 23, 79, 232, 84, 156, 184, 147, 196, 152 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 72, 183, 208, 26, 71, 231, 94, 231, 239, 4, 41, 13, 144, 133, 9, 144, 178, 8, 125, 177 }, new byte[] { 84, 164, 221, 81, 220, 228, 182, 188, 203, 215, 213, 21, 20, 35, 17, 145 } });
        }
    }
}
