using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterProject.Api.Migrations
{
    public partial class Add_AllRelationshipsComplete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConcentrationId",
                table: "Majors");

            migrationBuilder.AddColumn<int>(
                name: "MajorId",
                table: "Concentrations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 108, 64, 180, 106, 134, 131, 51, 116, 25, 65, 87, 109, 86, 251, 228, 17, 174, 88, 201, 132 }, new byte[] { 40, 148, 89, 112, 27, 189, 149, 25, 223, 105, 200, 2, 137, 71, 212, 41 } });

            migrationBuilder.CreateIndex(
                name: "IX_Concentrations_MajorId",
                table: "Concentrations",
                column: "MajorId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassesConcentrations_ClassId",
                table: "ClassesConcentrations",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassesConcentrations_ConcentrationId",
                table: "ClassesConcentrations",
                column: "ConcentrationId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassesConcentrations_Classes_ClassId",
                table: "ClassesConcentrations",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassesConcentrations_Concentrations_ConcentrationId",
                table: "ClassesConcentrations",
                column: "ConcentrationId",
                principalTable: "Concentrations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Concentrations_Majors_MajorId",
                table: "Concentrations",
                column: "MajorId",
                principalTable: "Majors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassesConcentrations_Classes_ClassId",
                table: "ClassesConcentrations");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassesConcentrations_Concentrations_ConcentrationId",
                table: "ClassesConcentrations");

            migrationBuilder.DropForeignKey(
                name: "FK_Concentrations_Majors_MajorId",
                table: "Concentrations");

            migrationBuilder.DropIndex(
                name: "IX_Concentrations_MajorId",
                table: "Concentrations");

            migrationBuilder.DropIndex(
                name: "IX_ClassesConcentrations_ClassId",
                table: "ClassesConcentrations");

            migrationBuilder.DropIndex(
                name: "IX_ClassesConcentrations_ConcentrationId",
                table: "ClassesConcentrations");

            migrationBuilder.DropColumn(
                name: "MajorId",
                table: "Concentrations");

            migrationBuilder.AddColumn<int>(
                name: "ConcentrationId",
                table: "Majors",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 116, 163, 156, 147, 181, 78, 190, 84, 245, 141, 204, 199, 236, 216, 12, 61, 210, 76, 37, 56 }, new byte[] { 206, 100, 174, 84, 47, 196, 185, 193, 133, 108, 126, 253, 186, 4, 155, 100 } });
        }
    }
}
