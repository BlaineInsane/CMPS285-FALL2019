using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterProject.Api.Migrations
{
    public partial class Update_UsersUsersClassesClassesTables_AddedRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 116, 163, 156, 147, 181, 78, 190, 84, 245, 141, 204, 199, 236, 216, 12, 61, 210, 76, 37, 56 }, new byte[] { 206, 100, 174, 84, 47, 196, 185, 193, 133, 108, 126, 253, 186, 4, 155, 100 } });

            migrationBuilder.CreateIndex(
                name: "IX_UsersClasses_ClassId",
                table: "UsersClasses",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersClasses_UserId",
                table: "UsersClasses",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersClasses_Classes_ClassId",
                table: "UsersClasses",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersClasses_Users_UserId",
                table: "UsersClasses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersClasses_Classes_ClassId",
                table: "UsersClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersClasses_Users_UserId",
                table: "UsersClasses");

            migrationBuilder.DropIndex(
                name: "IX_UsersClasses_ClassId",
                table: "UsersClasses");

            migrationBuilder.DropIndex(
                name: "IX_UsersClasses_UserId",
                table: "UsersClasses");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 153, 125, 192, 25, 77, 139, 50, 150, 172, 236, 117, 214, 148, 50, 125, 194, 240, 70, 219, 179 }, new byte[] { 47, 63, 110, 25, 245, 25, 190, 25, 232, 42, 126, 139, 28, 92, 178, 113 } });
        }
    }
}
